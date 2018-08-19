using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class GruposInvestigacion
    {
        
        public string nombre { get; set; }
        public string region { get; set; }
        public string ciudad { get; set; }
        public string areaInvestigacion { get; set; }
        public string clasificacion { get; set; }
        public string articulos { get; set; }

        public GruposInvestigacion(string nombre, string region, string ciudad, string areaInvestigacion,
                                    string clasificacion, string articulos)
        {
            this.nombre = nombre;
            this.region = region;
            this.ciudad = ciudad;
            this.areaInvestigacion = areaInvestigacion;
            this.clasificacion = clasificacion;
            this.articulos = articulos;
        }


    }
}
