using Microsoft.EntityFrameworkCore;
using Simu.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Questao> Questoes { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetProperties()
            //        .Where(p => p.ClrType == typeof(string))))
            //    property.Relational().ColumnType = "varchar(200)";

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
