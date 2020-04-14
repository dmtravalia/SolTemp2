using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class DadosContext : DbContext
    {
        public DadosContext(DbContextOptions<DadosContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DadosContext).Assembly);
        }
    }
}
