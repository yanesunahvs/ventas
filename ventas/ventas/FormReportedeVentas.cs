﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;

namespace ventas
{
    public partial class FormReportedeVentas : Form
    {
        public FormReportedeVentas()
        {
            InitializeComponent();
        }

        public void cargarDatos(FacturaBL facturaBL, ClientesBL clientesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
              from f in facturaBL.ListadeFacturas
              select new
              {
                  Id = f.Id,
                  Fecha = f.Fecha,
                  Cliente = clientesBL.ListadeClientes.FirstOrDefault(r => r.Id == f.ClienteId) .Nombre,
                  Subtotal = f.Subtotal,
                  Impuesto = f.Impuesto,
                  Activo = f.Activo,
 
              };

            var reporte = new ReportedeVentas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
