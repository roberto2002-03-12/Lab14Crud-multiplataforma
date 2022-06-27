using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Lab14Crud.Models;

namespace Lab14Crud.DataContext
{
    public class AppDbContext : DbContext
    {
        string DbPath = string.Empty;

        public DbSet<Estudiante> Estudiante { get; set; }

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
