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
        public Categoria Categoria { get; set; }
    }
}