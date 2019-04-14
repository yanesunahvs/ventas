using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;
using ventas.Modelos;

namespace ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var productosBL = new ProductosBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;

            var categoriasBL = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cargarDatos(ProductosBL productosBL, CategoriaBL categoriaBL)
        {
            
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;
            listadeCategoriasBindingSource.DataSource = categoriaBL.ListadeCategorias;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            var archivo = openFileDialog1.FileName;

            if (archivo != " ")
            {
                var fileInfo = new FileInfo(archivo);
                var fileStream = fileInfo.OpenRead();

                pictureBox1.Image = Image.FromStream(fileStream);

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
