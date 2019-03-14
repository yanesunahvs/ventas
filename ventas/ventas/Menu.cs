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
    public partial class Menu : Form
    {
        ProductosBL _productosBL;
        CategoriaBL _categoriaBL;
        ClientesBL _clientesBL;
        CiudadBL _ciudadBL;



        public Menu()
        {
            InitializeComponent();

            _productosBL = new ProductosBL();
            _categoriaBL = new CategoriaBL();
            _clientesBL = new ClientesBL();
            _ciudadBL = new CiudadBL();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form1();
            formProductos.MdiParent = this;
            formProductos.cargarDatos( _productosBL, _categoriaBL);
            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;

            formClientes.cargarDatos(_clientesBL, _ciudadBL);

            formClientes.Show();
        }
    }
}
