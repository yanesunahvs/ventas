using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //categoria
            var categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Nombre = "Rafael Caro";

            var categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Nombre = "Kiki Camarena";

            var categoria3 = new Categoria();
            categoria3.Id = 3;
            categoria3.Nombre = "Vladimir Levin";
            //ciudades
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "<Pochinki";

            Ciudad ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Bootcamp";

            Ciudad ciudad3 = new Ciudad();
            ciudad3.Id = 3;
            ciudad3.Descripcion = "Los leones";

            //clientes
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Rafael caro ";
            cliente1.Direccion = "calle sinaloa etapa 2";
            cliente1.categoria = categoria1;

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Kiki camarena ";
            cliente2.Direccion = "calle aldama bloque 5";
            cliente2.categoria = categoria2;

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Vladimir Levin ";
            cliente3.Direccion = "calle zacatecas, porton 1";
            cliente3.categoria = categoria3;

            //lista de ciudades
            var listadeCiudades = new List<Ciudad>();
            listadeCiudades.Add(ciudad1);
            listadeCiudades.Add(ciudad2);
            listadeCiudades.Add(ciudad3);

            foreach (var c in listadeCiudades)

                MessageBox.Show(c.Descripcion + " " + c.cliente.Nombre);
        }
    }
}
