﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class ProductosBL
    {
        public List<Producto> listadeProductos { get; set; }

        public ProductosBL()
        {
            listadeProductos = new List<Producto>();
            CreardatosdePrueba();
            
        }

        private void CreardatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop Dell", 20000, categoria1);
            var producto2 = new Producto(2, "Laptop Asus", 10000, categoria1);
            var producto3 = new Producto(3, "Mouse Logitech", 200, categoria2);

            listadeProductos.Add(producto1);
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);


        }

    }
}
