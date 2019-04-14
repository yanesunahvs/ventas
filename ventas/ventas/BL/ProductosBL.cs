using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class ProductosBL
    {
        public BindingList<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new BindingList<Producto>();
            CrearDatosdePrueba();

        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;
            foreach (var producto in ListadeProductos)
            {
                if (producto.Id == id)
                {
                    precio = producto.Precio;
                }
            }
            return precio;
        }

        public double ObtenerCosto(int id)
        {
            double costo = 0;
            foreach (var producto in ListadeProductos)
            {
                if (producto.Id == id)
                {
                    costo = producto.Costo;
                }
            }

            return costo;
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop Dell", 150000, categoria1);
            var fileInfo = new FileInfo(@"C:\Users\Yanes\Desktop\Lenguaje De Programacion ll\proyecto\Imagenes\laptop-dell.jpg ");
            var fileStream = fileInfo.OpenRead();

            producto1.Foto = Program.imageToByArray(Image.FromStream(fileStream));
           
        
            var producto2 = new Producto(2, "Laptop Asus", 20000, categoria1);
            fileInfo = new FileInfo(@"C: \Users\Yanes\Desktop\Lenguaje De Programacion ll\proyecto\Imagenes\laptop-asus.png");
            fileStream = fileInfo.OpenRead();

            producto2.Foto = Program.imageToByArray(Image.FromStream(fileStream));
            

           


            var producto3 = new Producto(3, "Mouse Logitech", 200, categoria2);
            fileInfo = new FileInfo(@"C: \Users\Yanes\Desktop\Lenguaje De Programacion ll\proyecto\Imagenes\mouse-logitech.jpg");
            fileStream = fileInfo.OpenRead();

            producto3.Foto = Program.imageToByArray(Image.FromStream(fileStream));

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

        }

    }
}
