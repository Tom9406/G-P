using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using G_P.Entities;


namespace G_P
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        // con esto definiremos el nombre de la tabla que se va a crear en el db 
        //Matrimonios
        public DbSet<matrimonios> Matrimonios { get; set; }

        
    }
}
