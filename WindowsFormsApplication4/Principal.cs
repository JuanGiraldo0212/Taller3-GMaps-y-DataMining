﻿using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{

    public class Principal
    {
        public ArrayList gruposInvestigacion;
        public static String ruta = "Registros.txt";
        

        public Principal()
        {
            gruposInvestigacion = new ArrayList();
            generarRegistros();
			generarArticulos();
        }

		public void generarRegistros()
		{
			String line;
			try
			{
				StreamReader sr = new StreamReader(ruta);

				line = "";

				while ((line = sr.ReadLine()) != null)
				{
					String[] cadena = line.Split(',');
					if (cadena.Length > 7)
					{
						GruposInvestigacion registroNuevo = new GruposInvestigacion(cadena[3], cadena[8], cadena[5], cadena[11], cadena[13], new string[0], cadena[2]);
						gruposInvestigacion.Add(registroNuevo);
					}
					else
					{
						string[] articulos = cadena[5].Trim().Split(' ');
						GruposInvestigacion registroNuevo = new GruposInvestigacion(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], articulos, "CODIGO");
						gruposInvestigacion.Add(registroNuevo);
					}
                    
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
		}

		public void escritura(String[] datos, string[] articulos)
        {
            try
            {

                //Ordena los articulos para escribir en el archivo de texto
                string articulosConcatenar = "";
                foreach (string articulitos in articulos)
                {
                    articulosConcatenar = articulosConcatenar + " " + articulitos;
                }

                StreamWriter sw = new StreamWriter(ruta, true);

                GruposInvestigacion registroNuevo = new GruposInvestigacion(datos[0], datos[1], datos[2], datos[3], datos[4], articulos, "CODIGO");
                sw.WriteLine(registroNuevo.nombre + "," + registroNuevo.region + "," + registroNuevo.ciudad + "," + registroNuevo.areaInvestigacion + "," + registroNuevo.clasificacion + "," + articulosConcatenar);
                
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

		public void generarArticulos()
		{
			StreamReader sr = new StreamReader("..\\..\\Articulos.txt");
			string line = "";
			try
			{
				int contador = 0;
				while ((line = sr.ReadLine()) != null)
				{
					String[] cadena = line.Split(':');
					Boolean encontrado = false;
					for(int i = 0; i<gruposInvestigacion.Count && !encontrado;i++)
					{
						GruposInvestigacion g = (GruposInvestigacion)gruposInvestigacion[i];
						if (g.codigo.Equals(cadena[1]))
						{
							string[] articulos = cadena[2].Trim().Split(' ');
							g.articulos = articulos;
							encontrado = true;
							contador++;
						}
					}
				}
				sr.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
		}
        public ArrayList getGrupos() {
            return gruposInvestigacion;
        }
    }
}
