using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagementService.Models;

namespace ProductManagementService.ProductData
{
    public class MockProductData : IProductData
    {
        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                Productcode = 001,
                Name = "Lavender heart",
                Price = 9.25M
            },
            new Product()
            {
                Productcode = 002,
                Name = "Personalised cufflinks",
                Price = 45.00M
            },
            new Product()
            {
                Productcode = 003,
                Name = "Kids T-shirt",
                Price = 19.95M
            }
        };


        public Product AddProduct(Product product)
        {
            if (products != null && !products.Any(x => x.Productcode == product.Productcode))
            {
                products.Add(product);
            }
            return product;
        }

        public void DeleteProduct(Product product)
        {
              products.Remove(product);          
        }

        public Product EditProduct(Product product)
        {
            var existingProduct = GetProduct(product.Productcode);
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            return product;
        }

        public Product GetProduct(int productCode)
        {
            return products.SingleOrDefault(x => productCode == x.Productcode);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
