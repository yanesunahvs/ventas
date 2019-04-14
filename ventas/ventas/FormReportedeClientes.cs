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
    public partial class FormReportedeClientes : Form
    {
        public FormReportedeClientes()
        {
            InitializeComponent();
        }

        public void caragarDatos(ClientesBL clientesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
              from cl in clientesBL.ListadeClientes
              select new
              {
                  Id = cl.Id,
                  Nombre = cl.Nombre,
                  Telefono = cl.Telefono,
                  Ciudad = cl.Ciudad,
                  Direccion = cl.Ciudad,
                  Categoria = cl.Categoria,
                 
              };

            var reporte = new ReportedeClientes();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
