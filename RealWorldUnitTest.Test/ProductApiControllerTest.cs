using Microsoft.AspNetCore.Mvc;
using Moq;
using RealWorldUnitTestWeb.App.Controllers;
using RealWorldUnitTestWeb.App.Helpers;
using RealWorldUnitTestWeb.App.Models;
using RealWorldUnitTestWeb.App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RealWorldUnitTest.Test
{
    public class ProductApiControllerTest
    { 
    //{
    //    private readonly Mock<IRepository<Products>> _mockRepo;
    //    private readonly ProductsApiController _controller;
    //    private readonly Helper _helper;
    //    private List<Products> _products;

    //    public ProductApiControllerTest()
    //    {
    //        _mockRepo = new Mock<IRepository<Products>>();
    //        _controller = new ProductsApiController(_mockRepo.Object);
    //        _helper = new Helper();
    //        _products = new List<Products>()
    //        {
    //            new Products() { Id = 1,Name="Kalem",Price=50,Stock=100,Color="Kırmızı"},
    //            new Products() { Id = 2,Name="Defter",Price=100,Stock=200,Color="Mavi"},
    //        };
    //    }

    //    [Theory]
    //    [InlineData(4,5,9)]
    //    public void Add_SampleValue_ReturnTotal(int num1, int num2,int total)
    //    {
    //        var result = _helper.Add(num1, num2);

    //        Assert.Equal(total, result);
    //    }
    //    //solution'a sağ tıklayıp open command line ile powershell açıp dotnet test yazdığımızda da tüm testleri yapar.


    //    [Fact]
    //    public async void GetProducts_ActionExecute_ReturnOkResultWithProduct()
    //    {
    //        _mockRepo.Setup(x => x.GetAll()).ReturnsAsync(_products);

    //        var result = await _controller.GetProducts();

    //        var okResult = Assert.IsType<OkObjectResult>(result);

    //        var returnProduct = Assert.IsAssignableFrom<IEnumerable<Products>>(okResult.Value);

    //        Assert.Equal<int>(2, returnProduct.ToList().Count);
    //    }

    //    [Theory]
    //    [InlineData(0)]
    //    public async void GetProducts_IdInValid_ReturnNotFound(int productId)
    //    {
    //        Products product = null;

    //        _mockRepo.Setup(x => x.GetById(productId)).ReturnsAsync(product);

    //        var result = await _controller.GetProducts(productId);

    //        Assert.IsType<NotFoundResult>(result);
    //    }

    //    [Theory]
    //    [InlineData(1)]
    //    [InlineData(2)]
    //    public async void GetProducts_IdValid_ReturnOkResult(int productId)
    //    {
    //        var product = _products.First(x => x.Id == productId);

    //        _mockRepo.Setup(x => x.GetById(productId)).ReturnsAsync(product);

    //        var result = await _controller.GetProducts(productId);

    //        var okResult = Assert.IsType<OkObjectResult>(result);

    //        var returnProduct = Assert.IsType<Products>(okResult.Value);

    //        Assert.Equal(productId,returnProduct.Id);
    //        Assert.Equal(product.Name,returnProduct.Name);
    //    }

    //    [Theory]
    //    [InlineData(1)]
    //    public void PutProducts_IdIsNotEqualProduct_ReturnBadRequestResult(int productId)
    //    {
    //        var product = _products.First(x => x.Id == productId);

    //        var result = _controller.PutProducts(2, product);

    //        Assert.IsType<BadRequestResult>(result);
    //    }

    //    [Theory]
    //    [InlineData(1)]
    //    public void PutProducts_ActionExecutes_ReturnNoContent(int productId)
    //    {
    //        var product = _products.First(x => x.Id == productId);

    //        _mockRepo.Setup(x => x.Update(product));

    //        var result = _controller.PutProducts(productId, product);

    //        _mockRepo.Verify(x => x.Update(product), Times.Once);

    //         Assert.IsType<NoContentResult>(result);
    //    }

    //    [Fact]
    //    public async void PostProducts_ActionExecute_ReturnCreateAction()
    //    {
    //        var product = _products.First();

    //        //I notificationing Task Completed with "Task.CompletedTask" statement.
    //        _mockRepo.Setup(x => x.Create(product)).Returns(Task.CompletedTask);

    //        var result = await _controller.PostProducts(product);

    //        var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);

    //        _mockRepo.Verify(x => x.Create(product), Times.Once);

    //        Assert.Equal("GetProducts", createdAtActionResult.ActionName);
    //    }

    //    [Theory]
    //    [InlineData(0)]
    //    public async void DeleteProducts_IdInValid_ReturnNotFound(int productId)
    //    {
    //        Products product = null;

    //        _mockRepo.Setup(x => x.GetById(productId)).ReturnsAsync(product);

    //        var result = await _controller.DeleteProducts(productId);

    //        Assert.IsType<NotFoundResult>(result.Result);
    //    }

    //    [Theory]
    //    [InlineData(1)]
    //    public async void DeleteProducts_ActionExecute_ReturnNoContent(int productId)
    //    {
    //        var product = _products.First(X => X.Id == productId);
          
    //        _mockRepo.Setup(x => x.GetById(productId)).ReturnsAsync(product);

    //        _mockRepo.Setup(x => x.Delete(product));

    //        var noContentResult = await _controller.DeleteProducts(productId);

    //        _mockRepo.Verify(x=>x.Delete(product),Times.Once);

    //        Assert.IsType<NoContentResult>(noContentResult.Result);
    //    }
    }
}
