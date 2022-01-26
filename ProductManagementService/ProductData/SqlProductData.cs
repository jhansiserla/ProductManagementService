using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagementService.Models;

namespace ProductManagementService.ProductData
{
    public class SqlProductData : IProductData
    {
        private ProductContext _productContext; 
        public SqlProductData(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public Product AddProduct(Product product)
        {
            _productContext.Products.Add(product);
            _productContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(Product product)
        {
            
         _productContext.Products.Remove(product);
         _productContext.SaveChanges();
        }

        public Product EditProduct(Product product)
        {
            var existingProduct = _productContext.Products.Find(product.Productcode);
            if (existingProduct != null)
            {
                existingProduct.Price = product.Price;
                existingProduct.Name = product.Name;
                _productContext.Products.Update(existingProduct);
                _productContext.SaveChanges();
            }
            return product;
        }

        public Product GetProduct(int productCode)
        {
            var product = _productContext.Products.Find(productCode);
            return product;
        }

        public List<Product> GetProducts()
        {
           return _productContext.Products.ToList();
        }
    }
}
