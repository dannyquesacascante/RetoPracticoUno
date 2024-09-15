using System.Collections.Generic;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using RetoPracticoUno.domain.Entities;

namespace RetoPracticoUno.Infraestructure.Repositorio
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tarea> Tarea { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

}
