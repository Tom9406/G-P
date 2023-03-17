
using System.Diagnostics.CodeAnalysis;
using G_P.Entities;
using Microsoft.EntityFrameworkCore;

namespace G_P
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
       
        // con esto definiremos el nombre de la tabla que se va a crear en el db 
        //Matrimonios
        public DbSet<matrimonios> matrimonios { get; set; }

        //Inscripciones
        public DbSet<inscribir_matrimoio> inscipciones { get; set; }

        //Anular
        public DbSet<anular_matrimonio> anular { get; set; }

        //Solicitar
        public DbSet<solicitar_matrimonio> solicitar { get; set; }



    }
}
