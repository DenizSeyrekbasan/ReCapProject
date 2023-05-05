using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //context nesnesi db tablolari ile proje class'larini baglama islemi
    public class ReCapDbContext: DbContext //DbContext Ef'den gelen base nesne
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projeyi db ile iliskilendiren metot on..
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Database=ReCapDb;Trusted_Connection=True;");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
