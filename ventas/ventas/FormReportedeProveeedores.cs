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
    public partial class FormReportedeProveeedores : Form
    {
        public FormReportedeProveeedores()
        {
            InitializeComponent();
        }
      public void cargarDatos(ProveedoresBL proveedoresBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
              from pr in proveedoresBL.ListadeProveedores

              select new
              {
                  Id = pr.Id,
                  Nombre = pr.Nombre,
                  Telefono = pr.Telefono,
                  
              };

            var reporte = new ReportedeProveedores();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
