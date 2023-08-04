using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Repository.Models;

namespace RepositoryService.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() => Database.EnsureCreated();
        public DbSet<Worker> Workers => Set<Worker>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=myPassword");
        }
    }


    /*
    public class SqliteDbContext:DbContext
    {
        public SqliteDbContext() => Database.EnsureCreated();
        public DbSet<Worker> Workers => Set<Worker>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
    */
}
