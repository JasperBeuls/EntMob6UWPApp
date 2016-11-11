using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntMob6UWP.Domain
{
    class DBContext : DbContext
    {
        public DbSet<Humidity> humidities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=db.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Humidity>()
                .HasKey(b => b.ID);
            modelBuilder.Entity<Humidity>()
                .Property(b => b.Percentage).HasColumnName("percentage");

        }
    }
}
