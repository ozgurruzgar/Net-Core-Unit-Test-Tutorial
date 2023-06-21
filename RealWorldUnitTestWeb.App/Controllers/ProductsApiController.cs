using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealWorldUnitTestWeb.App.Models;
using RealWorldUnitTestWeb.App.Repository;

namespace RealWorldUnitTestWeb.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        private readonly IRepository<Products> _repository;

        public ProductsApiController(IRepository<Products> repository)
        {
            _repository = repository;
        }

        // GET: api/ProductsApi
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var product = await _repository.GetAll();

            return Ok(product);
        }

        // GET: api/ProductsApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducts(int id)
        {
            var products = await _repository.GetById(id);

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        // PUT: api/ProductsApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutProducts(int id, Products products)
        {
            if (id != products.Id)
            {
                return BadRequest();
            }

            _repository.Update(products);

            //Put'ta ok yerine no content dönmek daha +'lı 
            return NoContent();
        }

        // POST: api/ProductsApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<IActionResult> PostProducts(Products products)
        {
            await _repository.Create(products);

            return CreatedAtAction("GetProducts", new { id = products.Id }, products);
        }

        // DELETE: api/ProductsApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Products>> DeleteProducts(int id)
        {
            var products = await _repository.GetById(id);
            if (products == null)
            {
                return NotFound();
            }

            _repository.Delete(products);

            return NoContent();
        }

        private bool ProductsExists(int id)
        {
            Products product = _repository.GetById(id).Result;

            if(product == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
