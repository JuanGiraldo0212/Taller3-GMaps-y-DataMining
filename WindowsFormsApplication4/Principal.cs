using System;
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
        String ruta = "Registros.txt";
        

        public Principal()
        {
            gruposInvestigacion = new ArrayList();
            generarRegistros();
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
						GruposInvestigacion registroNuevo = new GruposInvestigacion(cadena[3], cadena[8], cadena[5], cadena[11], cadena[13], "Articulos");
						gruposInvestigacion.Add(registroNuevo);
					}
					else
					{
						GruposInvestigacion registroNuevo = new GruposInvestigacion(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], cadena[5]);
						gruposInvestigacion.Add(registroNuevo);
					}
                    
				}

				sr.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
		}

		public void escritura(String[] datos)
        {
            try
            {

                StreamWriter sw = new StreamWriter(ruta, true);

                GruposInvestigacion registroNuevo = new GruposInvestigacion(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                sw.WriteLine(registroNuevo.nombre + "," + registroNuevo.region + "," + registroNuevo.ciudad + "," + registroNuevo.areaInvestigacion + "," + registroNuevo.clasificacion + "," + registroNuevo.articulos);
                
                sw.Close();
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
