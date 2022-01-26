using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementService.Models
{
    public class Product
    {
      
        /// <summary>
        /// Product Code. 
        /// </summary>
        [Key]
        public int Productcode { get; set; }

        /// <summary>
        /// Name of product.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Price of product.
        /// </summary>
        [Required]
        public decimal Price { get; set; }
    }
}
