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
        FacturaBL _facturaBL;
        ProveedoresBL _proveedoresBL;
        ComprasBL _comprasBL;
        UsuariosBL _usuariosBL;




        public Menu()
        {
            InitializeComponent();

            _productosBL = new ProductosBL();
            _categoriaBL = new CategoriaBL();
            _clientesBL = new ClientesBL();
            _ciudadBL = new CiudadBL();
            _facturaBL = new FacturaBL();
            _proveedoresBL = new ProveedoresBL();
            _comprasBL = new ComprasBL();
            _usuariosBL = new UsuariosBL();

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

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formfactura = new Form3();
            formfactura.MdiParent = this;

            formfactura.cargarDatos(_facturaBL, _clientesBL, _productosBL);

            formfactura.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproveedores = new Form4();
            formproveedores.MdiParent = this;

            formproveedores.cargarDatos(_proveedoresBL);

            formproveedores.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCompras = new Form5();
           formCompras.MdiParent = this;

            formCompras.cargarDatos(_comprasBL, _proveedoresBL, _productosBL);

            formCompras.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.CargarDatos(_usuariosBL);

            login.ShowDialog();

            productosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProductos;
            facturaToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerFacturas;
            clientesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerClientes;


            proveedoresToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProveedores;
            comprasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerCompras;

            reporteDeClientesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReportes;
        }
    }
}
