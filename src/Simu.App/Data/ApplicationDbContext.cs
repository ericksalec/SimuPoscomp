using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simu.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simu.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Questao> Questoes { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }

    }
}
