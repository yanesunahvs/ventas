﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.BL;
using ventas.Modelos;

namespace ventas
{
   public  class Compras
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ProveedorId { get; set; }
        public Proveedores  proveedores { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<ComprasDetalle> ComprasDetalle { get; set; }

        public Compras()
        {
            Fecha = DateTime.Now;
            Activo = true;
            ComprasDetalle = new BindingList<ComprasDetalle>();
            
        }
        public void CalcularTotalcompras()
        {

            var productosBL = new ProductosBL();

            double subtotal = 0;
            foreach (var detalle in ComprasDetalle)
            {
                var costo = productosBL.ObtenerCosto(detalle.ProductoId);

                subtotal = subtotal + detalle.CalcularTotalCompras(costo);
            }

            Subtotal = subtotal;
            Impuesto = subtotal * 0.15;
            Total = Subtotal + Impuesto;
            
        }

        }

    }

    public class ComprasDetalle
    {
        public double costo;

        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double Total { get; set; }

        public ComprasDetalle()
        {
            Cantidad = 1;
            ProductoId = 1;
            
        }

        public double CalcularTotalCompras(double costo)
        {

        Costo = costo;
        Total = Cantidad * Costo;

            return Total;
        }

        
    }

