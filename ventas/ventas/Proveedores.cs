﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        

        public Proveedores()
        {
            Categoria = new Categoria(1, "San Pedro Sula");
        }


        public Proveedores(int id, string nombre, int telefono, string ciudad, string direccion, Categoria categoria)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ciudad = ciudad;
            Direccion = direccion;
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }
    }
}
