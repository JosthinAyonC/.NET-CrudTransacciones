using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{

    public class EmpresaContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=act4jul;User Id=postgres;Password=lokoloko21;");
            }
        }

    }

}
