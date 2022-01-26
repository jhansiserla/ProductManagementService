using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManagementService.ProductData;
using ProductManagementService.Models;
using Newtonsoft.Json;

namespace ProductManagementService.Controllers
{
    /// <summary>
    /// This controller is to manage products of online marketing.
    /// </summary>
    [Route("v1/")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductData _productData;

        public ProductsController(IProductData productData)
        {
            _productData = productData;
        }
        /// <summary>
        /// This method is to fetch list of all products.
        /// </summary>
        /// <returns></returns>
       
        [HttpGet("[controller]")]
        
        public IActionResult Get()
        {
            return Ok(JsonConvert.SerializeObject(_productData.GetProducts()));
        }

        /// <summary>
        /// This method is to get specific product information.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        
        [HttpGet("product/{code}")]
        
       public IActionResult Get(int code)
        {
            var product = _productData.GetProduct(code);
            if (product != null)
            {
                return Ok(JsonConvert.SerializeObject(product)); 
            }
            return NotFound($"Product with code: {code} was not found");
        }

        /// <summary>
        /// This method is to add new product information.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        
        [HttpPost("product")]
        
        public IActionResult Post(Product product)
        {
            _productData.AddProduct(product);
            return Created(HttpContext.Request.Scheme + "://" 
                + HttpContext.Request.Host + HttpContext.Request.Path +
                "://" + product.Productcode, JsonConvert.SerializeObject(product));

        }

        /// <summary>
        /// This method is to update existing product information.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut("product/{code}")]
        
        public IActionResult Put(int code, Product product)
        {
            var existingProduct = _productData.GetProduct(code);
            if (existingProduct != null)
            {
                product.Productcode = existingProduct.Productcode;
                _productData.EditProduct(product);
                return Ok(JsonConvert.SerializeObject(product));
            }

            return NotFound($"Product with code: {code} was not found");
        }

        /// <summary>
        /// This method is to delete existing product data.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpDelete("product/{code}")]
        
        public IActionResult Delete(int code)
        {
            var product = _productData.GetProduct(code);
            if (product != null)
            {
                _productData.DeleteProduct(product);
                return Ok(JsonConvert.SerializeObject(product));
            }
            
             return NotFound($"Product with code: {code} was not found");
        }
    }
}
