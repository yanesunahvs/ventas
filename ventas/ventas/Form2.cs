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
using ventas.Modelos;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void cargarDatos(ProductosBL productosBL, CategoriaBL categoriasBL)
        {

            listadeProductosBindingSource.DataSource = productosBL.listadeProductos;
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;

        }

        public void cargarDatos(ClientesBL clientesBL, CiudadBL ciudadBL)
        {
            
            listadeCiudaddesBindingSource.DataSource = ciudadBL.ListadeCiudades;

            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
        }

        private void listadeProductosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listadeClientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
