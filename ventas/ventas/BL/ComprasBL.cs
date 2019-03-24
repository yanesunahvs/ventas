using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas.BL
{
   public  class ComprasBL
    {
        public BindingList<Compras> ListadeCompras { get; set; }

        public ComprasBL()
        {
            ListadeCompras = new BindingList<Compras>();
        }

    }
}
