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
    public partial class Menu2 : Form
    {

        ComprasBL _comprasBL;
        ProveedoresBL _proveedoresBL;
        ProductosBL _productosBL;
        CategoriaBL _categoriaBL;
        public Menu2()
        {
            InitializeComponent();

            _comprasBL = new ComprasBL();
            _proveedoresBL = new ProveedoresBL();
            _productosBL = new ProductosBL();
            _categoriaBL = new CategoriaBL();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCompras = new Form5();
            formCompras.MdiParent = this;
            formCompras.cargarDatos(_comprasBL, _proveedoresBL, _productosBL);

            formCompras.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new Form4();
            formProveedores.MdiParent = this;

            formProveedores.cargarDatos(_proveedoresBL, _categoriaBL);

            formProveedores.Show();
        }
    }
}
