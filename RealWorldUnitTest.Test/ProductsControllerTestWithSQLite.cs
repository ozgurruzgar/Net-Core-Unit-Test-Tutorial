using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using RealWorldUnitTestWeb.App.Controllers;
using RealWorldUnitTestWeb.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RealWorldUnitTest.Test
{
    public class ProductsControllerTestWithSQLServerLocalDb:ProductsControllerTest
    {
        public ProductsControllerTestWithSQLServerLocalDb()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            SetContextOptions(new DbContextOptionsBuilder<UdemyUnitTestDbContext>().UseSqlite(connection).Options);
        }

        [Fact]
        public async Task Create_ModelValidProduct_ReturnRedirectToActionWithSaveProduct()
        {

            var newProduct = new Products {Name = "Kalem 30", Price = 200, Stock = 100};
            using (var context = new UdemyUnitTestDbContext(_contextOptions))
            {
                var category = context.Category.First();

                newProduct.CategoryId = category.Id;

                var controller = new ProductsController(context); 
                
                var result = await controller.Create(newProduct);

                var redirect = Assert.IsType<RedirectToActionResult>(result);

                Assert.Equal("Index", redirect.ActionName);
            }

            using (var context = new UdemyUnitTestDbContext(_contextOptions))
            {
                var product = context.Products.FirstOrDefault(p=>p.Name==newProduct.Name);

                Assert.Equal(newProduct.Name, product.Name);
            }
        }

        [Theory]
        [InlineData(1)]
        public async Task DeleteProduct_ExistCategoryId_DeletedAllProducts(int categoryId)
        {
            using (var context = new UdemyUnitTestDbContext(_contextOptions))
            {
                var category = await context.Category.FindAsync(categoryId);

                Assert.NotNull(category);

                context.Category.Remove(category);

                context.SaveChanges();
            }

            using (var context = new UdemyUnitTestDbContext(_contextOptions))
            {
                var products = await context.Products.Where(x => x.CategoryId == categoryId).ToListAsync();

                Assert.Empty(products);
            }

        }
    }
}
