using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVehiculo.BL
{
   public class MarcasBL
    {
        Contexto _contexto;
        public List<Marca> ListadeMarcas { get; set; }
        public MarcasBL()
        {
            _contexto = new Contexto();
            ListadeMarcas = new List<Marca>();
        }

        public List<Marca> Obtener()
        {
            ListadeMarcas = _contexto.Marcas.ToList();
            return ListadeMarcas;
        }
        public void GuardarMarca(Marca  marca)
        {
            if (marca.Id == 0)
            {
                _contexto.Marcas.Add(marca);

            }
            else
            {
                var marcaexistente = _contexto.Marcas.Find(marca.Id);
                marcaexistente.Descripcion = marca.Descripcion;
            }


            _contexto.SaveChanges();

        }

        public Marca Obtener(int Id)
        {
            var marca = _contexto.Marcas.Find(Id);
            return marca;
        }

        public void EliminarMarca(int Id)
        {
            var marca = _contexto.Marcas.Find(Id);

            _contexto.Marcas.Remove(marca);
            _contexto.SaveChanges();
        }
    }
}
