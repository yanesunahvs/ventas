using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }

                                           
        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();
            
        }

       private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Nombres");
            var categoria2 = new Categoria(2, "Ciudades");


            var cliente1 = new Cliente(111, "Ricardo Milos", 88778899, "Brasilia", "Brasil", categoria1);
            var cliente2 = new Cliente(222, "Kiki Camarena", 99223344, "Tijuana", "Mexico", categoria2);
            var cliente3 = new Cliente(333, "Cristofer Deku", 99240228, "La Union", "SPS, Honduras", categoria2);



            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
