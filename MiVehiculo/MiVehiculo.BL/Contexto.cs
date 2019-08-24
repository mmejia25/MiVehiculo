using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVehiculo.BL
{
   public class Contexto: DbContext
    {
        public Contexto() : base("Server=L000SPSIT01;Database=MiVehiculoDB;Trusted_Connection=True;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       // public DbSet<Marca> Marcas { get; set; }
        //public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
