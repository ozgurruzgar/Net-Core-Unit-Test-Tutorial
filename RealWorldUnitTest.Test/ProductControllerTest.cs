using Microsoft.AspNetCore.Mvc;
using Moq;
using RealWorldUnitTestWeb.App.Controllers;
using RealWorldUnitTestWeb.App.Models;
using RealWorldUnitTestWeb.App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace RealWorldUnitTest.Test
{
    public class ProductControllerTest
    {
        //private readonly Mock<IRepository<Products>> _mockRepo;
        //private readonly ProductsController _controller;
        //private List<Products> _products;
        //public ProductControllerTest()
        //{
        //    _mockRepo = new Mock<IRepository<Products>>();
        //    _controller = new ProductsController(_mockRepo.Object);
        //    _products = new List<Products>() 
        //    {
        //        new Products() { Id = 1,Name="Kalem",Price=50,Stock=100,Color="Kırmızı"}, 
        //        new Products() { Id = 2,Name="Defter",Price=100,Stock=200,Color="Mavi"},
        //    };
        //}

        //[Fact]
        //public async void Index_ActionExecutes_ReturnView()
        //{
        //    var result = await _controller.Index();

        //    Assert.IsType<ViewResult>(result);
        //}
        //[Fact]
        //public async void Index_ActionExecutes_ReturnProductList()
        //{
        //    _mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_products);

        //    var result = await _controller.Index();

        //    var viewResult = Assert.IsType<ViewResult>(result);

        //    var productList = Assert.IsAssignableFrom<IEnumerable<Products>>(viewResult.Model);

        //    Assert.Equal<int>(2, productList.Count());
        //}
        
        //[Fact]
        //public async void Details_IdIsNull_ReturnRedirectToIndexAction()
        //{
        //    var result = await _controller.Details(null);

        //    var redirect = Assert.IsType<RedirectToActionResult>(result);

        //    Assert.Equal("Index", redirect.ActionName);
        //}

        //[Fact]
        //public async void Details_IdInValid_ReturnNotFound()
        //{
        //    Products product = null;

        //    _mockRepo.Setup(x => x.GetById(0)).ReturnsAsync(product);

        //    var result = await _controller.Details(0);

        //    var redirect = Assert.IsType<NotFoundResult>(result);

        //    Assert.Equal<int>(404, redirect.StatusCode);
        //}

        //[Theory]
        //[InlineData(1)]
        //public async void Details_ValidId_ReturnProduct(int productId)
        //{
        //    Products products = _products.First(x => x.Id == productId);

        //    _mockRepo.Setup(repo => repo.GetById(1)).ReturnsAsync(products);

        //    var result = await _controller.Details(productId);

        //    var viewResult = Assert.IsType<ViewResult>(result);

        //    var resultProduct = Assert.IsAssignableFrom<Products>(viewResult.Model);

        //    Assert.Equal(products.Id, resultProduct.Id);
        //    Assert.Equal(products.Name, resultProduct.Name);
        //}

        //[Fact]
        //public void Create_ActionExecute_ReturnView()
        //{
        //    var result = _controller.Create();

        //    Assert.IsType<ViewResult>(result);
        //}

        //[Fact]
        //public async void CreatePost_InValidModelState_ReturnView()
        //{
        //    _controller.ModelState.AddModelError("Name", "Name alanı gerekli");

        //    var result = await _controller.Create(_products.First());

        //    var viewResult = Assert.IsType<ViewResult>(result);

        //    Assert.IsType<Products>(viewResult.Model);
        //}

        //[Fact]
        //public async void CreatePost_ValidModelState_ReturnRedirectToIndexAction()
        //{
        //    var result = await _controller.Create(_products.First());

        //    var redirect = Assert.IsType<RedirectToActionResult>(result);

        //    Assert.Equal("Index", redirect.ActionName);
        //}

        //[Fact]
        //public async void CreatePost_ValidModelState_CreateMethodExecute()
        //{
        //    Products newProduct = null;

        //    _mockRepo.Setup(repo => repo.Create(It.IsAny<Products>())).Callback<Products>(x => newProduct = x);

        //    var result = await _controller.Create(_products.First());

        //    _mockRepo.Verify(repo => repo.Create(It.IsAny<Products>()), Times.Once);

        //    Assert.Equal(_products.First().Id, newProduct.Id);
        //}

        //[Fact]
        //public async void CreatePort_InValidModelState_NeverCreateExecute()
        //{
        //    _controller.ModelState.AddModelError("Name", "Name alanı gereklidir.");

        //    var result = await _controller.Create(_products.First());

        //    _mockRepo.Verify(repo => repo.Create(It.IsAny<Products>()), Times.Never);
        //}

        //[Fact]
        //public async void Edit_IdIsNull_ReturnRedirectToIndexAction()
        //{
        //    var result = await _controller.Edit(null);

        //    var redirect = Assert.IsType<RedirectToActionResult>(result);

        //    Assert.Equal("Index", redirect.ActionName);
        //}

        //[Theory]
        //[InlineData(3)]
        //public async void Edit_IdInValid_ReturnNotFound(int productId)
        //{
        //    Products product = null;

        //    _mockRepo.Setup(repo => repo.GetById(productId)).ReturnsAsync(product);

        //    var result = await _controller.Edit(productId);

        //    var redirect = Assert.IsType<NotFoundResult>(result);

        //    Assert.Equal(404, redirect.StatusCode);
        //}

        //[Theory]
        //[InlineData(2)]
        //public async void Edit_ActionExecute_ReturnProduct(int productId)
        //{
        //    var product = _products.First(x => x.Id == productId);

        //    _mockRepo.Setup(repo => repo.GetById(productId)).ReturnsAsync(product);

        //    var result = await _controller.Edit(productId);

        //    var viewResult = Assert.IsType<ViewResult>(result);

        //    var resultProduct = Assert.IsAssignableFrom<Products>(viewResult.Model);

        //    Assert.Equal(product.Id, resultProduct.Id);
        //    Assert.Equal(product.Name, resultProduct.Name);
        //}

        //[Theory]
        //[InlineData(1)]
        //public void EditPost_IdIsNotEqualProduct_ReturnNotFound(int productId)
        //{
        //    var result = _controller.Edit(2,_products.First(x=>x.Id==productId));

        //    var redirect = Assert.IsType<NotFoundResult>(result);
        //}

        //[Theory]
        //[InlineData(1)]
        //public void EditPost_InValidModelState_ReturnView(int productId)
        //{
        //    _controller.ModelState.AddModelError("Name", "");

        //    var result = _controller.Edit(productId, _products.First(x => x.Id == productId));

        //    var viewResult = Assert.IsType<ViewResult>(result);

        //    Assert.IsType<Products>(viewResult.Model);
        //}


        //[Theory]
        //[InlineData(1)]
        //public void EditPost_ValidModelState_ReturnRedirectToAction(int productId)
        //{
        //    var result = _controller.Edit(productId, _products.First(x => x.Id == productId));

        //    var redirect = Assert.IsType<RedirectToActionResult>(result);

        //    Assert.Equal("Index", redirect.ActionName);
        //}

        //[Theory]
        //[InlineData(1)]
        //public void EditPost_ValidModelState_ReturnUpdateMethodExecute(int productId)
        //{
        //    var product = _products.First(x => x.Id ==productId);

        //    _mockRepo.Setup(repo => repo.Update(product));

        //    _controller.Edit(productId, product);

        //    _mockRepo.Verify(repo => repo.Update(It.IsAny<Products>()), Times.Once);
        //}

        //[Fact]
        //public async void Delete_IdIsNull_ReturnNotFound()
        //{
        //    var result = await _controller.Delete(null);

        //    var redirect = Assert.IsType<NotFoundResult>(result);
        //}

        //[Theory]
        //[InlineData(0)]
        //public async void Delete_IdIsNotEqualProduct_ReturnNotFound(int productId)
        //{
        //    Products product = null;

        //    _mockRepo.Setup(x => x.GetById(productId)).ReturnsAsync(product);

        //    var result = await _controller.Delete(productId);

        //    Assert.IsType<NotFoundResult>(result);
        //}

        //[Theory]
        //[InlineData(1)]
        //public async void Delete_ActionExecute_ReturnProduct(int productId)
        //{
        //    var product = _products.First(x => x.Id == productId);

        //    _mockRepo.Setup(repo => repo.GetById(productId)).ReturnsAsync(product);

        //    var result = await _controller.Delete(productId);

        //    var viewResult = Assert.IsType<ViewResult>(result);

        //    Assert.IsAssignableFrom<Products>(viewResult.Model);
        //}

        //[Theory]
        //[InlineData(1)]
        //public async void DeleteConfirmed_ActionExecutes_ReturnRedirectToAction(int productId)
        //{
        //    var result = await _controller.DeleteConfirmed(productId);

        //    Assert.IsType<RedirectToActionResult>(result);
        //}

        //[Theory]
        //[InlineData(1)]
        //public async void DeleteConfirmed_ActionExecutes_DeleteMethodExecute(int productId)
        //{
        //    var product = _products.First(x => x.Id == productId);

        //    _mockRepo.Setup(repo => repo.Delete(product));

        //    await _controller.DeleteConfirmed(productId);

        //    _mockRepo.Verify(repo => repo.Delete(It.IsAny<Products>()),Times.Once);
        //}

        //[Theory]
        //[InlineData(3)]
        //public void ProductExits_IdIsNotEqaulProduct_ReturnFalse(int productId)
        //{
        //   Products products = null;

        //  _mockRepo.Setup(repo => repo.GetById(productId)).ReturnsAsync(products);

        //  var result =  _controller.ProductsExists(productId);

        //  Assert.IsType<bool>(result);

        //  Assert.Equal("False", result.ToString());
        //}

        //[Theory]
        //[InlineData(1)]
        //public void ProductExists_IdIsValid_ReturnTrue(int productId)
        //{

        //    _mockRepo.Setup(repo => repo.GetById(productId)).ReturnsAsync(_products.First(x=>x.Id==productId));

        //    var result = _controller.ProductsExists(productId);

        //    Assert.IsType<bool>(result);

        //    Assert.Equal("True", result.ToString());
        //}
    }
}
