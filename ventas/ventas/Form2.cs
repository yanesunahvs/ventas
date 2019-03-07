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
using ventas.Modelos;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var produtosBl = new ProductosBL();
            listadeProductosBindingSource.DataSource = produtosBl.listadeProductos;


            
            

    var clientesBL = new ClientesBL();
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;

            var categoriasBL = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
    
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
