using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class ProveedoresBL
    {
        public BindingList<Proveedores> ListadeProveedores { get; set; }

        public ProveedoresBL()
        {
            ListadeProveedores = new BindingList<Proveedores>();
        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Nombres");
            var categoria2 = new Categoria(2, "Ciudades");


            var proveedor1 = new Proveedores(111, "Ricardo Milos", 88778899, "Brasilia", "Brasil", categoria1);
            var proveedor2 = new Proveedores(222, "Kiki Camarena", 99223344, "Tijuana", "Mexico", categoria2);
            var proveedor3 = new Proveedores(333, "Cristofer Deku", 99240228, "La Union", "SPS, Honduras", categoria2);



            ListadeProveedores.Add(proveedor1);
            ListadeProveedores.Add(proveedor2);
            ListadeProveedores.Add(proveedor3);
        }

    }
}
