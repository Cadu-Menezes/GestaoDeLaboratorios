using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeLaboratorios.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base (options) 
        { 
            
        }

        public DbSet<Computadores> Computadores { get; set; }

    }
}
