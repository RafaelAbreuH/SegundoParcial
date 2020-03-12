using Microsoft.EntityFrameworkCore;
using SegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Llamadas> llamadas { get; set; }
        public DbSet<LlamadasDetalle> llamadasDetalle { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Database/Data.db");
        }
    }
}
