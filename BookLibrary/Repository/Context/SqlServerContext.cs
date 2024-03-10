using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }

       
        public DbSet<Books> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar a chave primária com autoincremento
            modelBuilder.Entity<Books>()
                .HasKey(b => b.BookId);
            modelBuilder.Entity<Books>()
                .Property(b => b.BookId)
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}