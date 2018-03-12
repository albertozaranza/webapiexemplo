using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Registro> Registros { get; set; }

        private static IConfigurationRoot Configuration;

        public StoreContext()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = (Configuration.GetConnectionString("StoreDB"));
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>()
                .HasKey(r => new { r.CarroId, r.FuncionarioId });

            modelBuilder.Entity<Registro>()
                .HasOne(f => f.Funcionario)
                .WithMany(reg => reg.Registros)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
