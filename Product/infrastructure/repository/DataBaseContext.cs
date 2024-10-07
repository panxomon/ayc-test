
using Microsoft.EntityFrameworkCore;
using test.api.domain;

namespace api.test.infrastructure 
{
    public class DataBaseContext : DbContext
    {   
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;ConnectRetryCount=0");
        }   
    }

}


