using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://xamlbrewer.wordpress.com/2016/06/01/getting-started-with-sqlite-and-entity-framework-on-uwp/
/// https://docs.efproject.net/en/latest/platforms/index.html
/// </summary>
namespace DevAnimals.Desktop.Models
{
   public class DevAnimalsContext : DbContext
    {
        internal DbSet<Category> Categories { get; set; }
        internal DbSet<RegisterClass> Accounts { get;set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=DevAnimals.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Make IdCategory required
            modelBuilder.Entity<Category>()
                .HasKey(p => p.IdCategory)
                .HasName("PrimaryKey_IdCategory");
            modelBuilder.Entity<RegisterClass>()
                .HasKey(p => p.IdUser)
                .HasName("PrimaryKey_IdUser");
        }

        
    }
}
