using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class CiudadBL
    {
        public List<Ciudad> ListadeCiudaddes { get; set; }

        public CiudadBL()

        {
            ListadeCiudaddes = new List<Ciudad>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Brasilia");
            var ciudad2 = new Ciudad(2, "Tijuana");
            var ciudad3 = new Ciudad(3, "La Union");

            ListadeCiudaddes.Add(ciudad1);
            ListadeCiudaddes.Add(ciudad2);
            ListadeCiudaddes.Add(ciudad3);

        }
    }
}
