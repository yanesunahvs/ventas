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
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            
            var proveedor1 = new Proveedores(111, "Ricardo Milos", 88778899);
            var proveedor2 = new Proveedores(222, "Kiki Camarena", 99223344);
            var proveedor3 = new Proveedores(333, "Cristofer Deku", 99240228);



            ListadeProveedores.Add(proveedor1);
            ListadeProveedores.Add(proveedor2);
            ListadeProveedores.Add(proveedor3);
        }

    }
}
