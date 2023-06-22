using Microsoft.EntityFrameworkCore;
using RealWorldUnitTestWeb.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldUnitTest.Test
{
    public class ProductsControllerTest
    {
        protected DbContextOptions<UdemyUnitTestDbContext> _contextOptions { get; private set; }

        public void SetContextOptions(DbContextOptions<UdemyUnitTestDbContext> contextOptions)
        {
            _contextOptions = contextOptions;
            SeedData();
        }

        public void SeedData()
        {
            using (UdemyUnitTestDbContext context = new UdemyUnitTestDbContext(_contextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Category.Add(new Category() {  Name = "Kalemler" });
                context.Category.Add(new Category() {  Name = "Defterler" });
                context.SaveChanges();

                context.Products.Add(new Products() { CategoryId = 1, Name = "Kalem 10", Price = 100, Stock = 100, Color = "Kırmızı" });
                context.Products.Add(new Products() { CategoryId = 1, Name = "Kalem 20", Price = 100, Stock = 100, Color = "Mavi" });
                context.SaveChanges();
            }
        } 
    }
}
