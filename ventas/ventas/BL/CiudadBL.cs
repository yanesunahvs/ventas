﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class CiudadBL
    {
        public BindingList<Ciudad> ListadeCiudades { get; set; }

        public CiudadBL()

        {
            ListadeCiudades = new BindingList<Ciudad>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Brasilia");
            var ciudad2 = new Ciudad(2, "Tijuana");
            var ciudad3 = new Ciudad(3, "La Union");

            ListadeCiudades.Add(ciudad1);
            ListadeCiudades.Add(ciudad2);
            ListadeCiudades.Add(ciudad3);

        }
    }
}
