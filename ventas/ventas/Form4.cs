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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
          public void cargarDatos(ProveedoresBL proveedoresBL, CategoriaBL categoriaBL)
        {
            listadeProveedoresBindingSource.DataSource = proveedoresBL.ListadeProveedores;
            listadeCategoriasBindingSource.DataSource = categoriaBL.ListadeCategorias;
        }

        private void listadeCategoriasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

        
    }

