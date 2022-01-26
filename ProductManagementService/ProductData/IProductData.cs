using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagementService.Models;

namespace ProductManagementService.ProductData
{
  public interface IProductData
    {
        /// <summary>
        /// Method to get list of all products
        /// </summary>
        /// <returns></returns>
        List<Product> GetProducts();

        /// <summary>
        /// Method to get specific product information
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        Product GetProduct(int productCode);

        /// <summary>
        /// Method to add product into Database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product AddProduct(Product product);

        /// <summary>
        /// Method to edit any existing product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product EditProduct(Product product);

        /// <summary>
        /// Method to delete sepcific product from database
        /// </summary>
        /// <param name="product"></param>
        void DeleteProduct(Product product);

    }
}
