using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Model
{
    class FileProcessorDbContext : DbContext
    {
        public DbSet<Zbozi> Zbozi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FileProcessorDb;Trusted_Connection=True;");
        }
    }
}
