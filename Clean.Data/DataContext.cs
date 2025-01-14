using Clean.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Prison_Guard> guards { get; set; }
        public DbSet<Prisoner> prisoners { get; set; }
        public DbSet<Room> rooms { get; set; }
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=my_db");
        }
    }
}
