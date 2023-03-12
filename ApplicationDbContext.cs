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
        public DbSet<Genre> Genres { get; set; }

        //EXAM 
        public DbSet<exam> Subjects { get; set; }

        //User
        public DbSet<user> User { get; set; }

        //Login
        public DbSet<login> login { get; set; }

        //Score
        public DbSet<Score> Score { get; set; }
    }
}
