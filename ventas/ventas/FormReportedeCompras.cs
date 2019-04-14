using System;
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
    public partial class FormReportedeCompras : Form
    {
        public FormReportedeCompras()
        {
            InitializeComponent();
        }

        public void cargarDatos(ComprasBL comprasBL, ProveedoresBL proveedoresBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
              from c in comprasBL.ListadeCompras
              select new
              {
                  Id = c.Id,
                  Fecha = c.Fecha,
                  Proveedores = proveedoresBL.ListadeProveedores.FirstOrDefault(r => r.Id == c.ProveedorId)
                  .Nombre,
                  Subtotal = c.Subtotal,
                  Impuesto =c.Impuesto,
                  Total = c.Total,
                  Activo = c.Activo,

              };

            var reporte = new ReportedeCompras();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
