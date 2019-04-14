﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.Modelos
{
   public  class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public int CategoriaId { get; set; }
        public byte[] Foto { get; set; }
        public Categoria Categoria { get; set; }

        public Producto()
        {
            Categoria = new Categoria(1, "Laptop Dell");
            

        }

        public Producto(int id, string descripcion, double precio, Categoria categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }


    }
}
