﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas
{
   public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public Producto()
        {
            Categoria = new Categoria(1, "Laptops ");
            CategoriaId = Categoria.Id;
        }

        public Producto(int id, string descripcion, double precio, Categoria categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = categoria;
            CategoriaId = Categoria.Id;

        }
    }
}
