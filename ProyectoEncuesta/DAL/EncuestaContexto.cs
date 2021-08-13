using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProyectoEncuesta.DAL
{
    public class EncuestaContexto:DbContext
    {
        public EncuestaContexto() : base("EncuestaContexto")
        {
        }


        public DbSet<Models.Encuesta> Encuesta { get; set; }
        public DbSet<Models.Campo> Campo { get; set; }
        public DbSet<Models.Respuesta> Respuesta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}