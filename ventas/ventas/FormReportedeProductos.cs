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
    public partial class FormReportedeProductos : Form
    {
        public FormReportedeProductos()
        {
            InitializeComponent();
        }

        public void cargarDatos (ProductosBL productosBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
              from p in productosBL.ListadeProductos
              select new
              {
                  Foto = p.Foto,
                  Id = p.Id,
                  Descripcion = p.Descripcion,
                  Categoria = p.Categoria.Descripcion,
                  Precio = p.Precio,
              };

            var reporte = new ReportedeProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
