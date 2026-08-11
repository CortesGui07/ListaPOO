using ListaPOO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOO.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql("Host=projetoscti.com.br;" +
                "Port=54432;" +
                "Database=cti_db;" +
                "Username=v1tor;" +
                "Password=1234");
        }

        public DbSet <Contato> Contatos { get; set; }
    }
}
