using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePruebaLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaproductos = new List<Producto>();
            listaproductos.Add(new Producto(1, "Laptop", 10));
            listaproductos.Add(new Producto(2, "Teclado", 8));
            listaproductos.Add(new Producto(3, "Mouse", 0));
            listaproductos.Add(new Producto(4, "Bateria", 5));
            listaproductos.Add(new Producto(5, "USB", 0));


            var query = listaproductos.Where(r => r.Existencia > 0  );

            foreach (var producto in query)
            {
                Console.WriteLine(producto.Descripcion);
            }

            Console.ReadLine();

        }
    }

    class Producto
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public bool Activo { get; set; }
        public int Existencia { get; set; }

        public Producto(int id, string descripcion, int existencia)
        {
            Id = id;
            Descripcion = descripcion;
            Existencia = existencia;
            Activo = true;
        }

    }

}
