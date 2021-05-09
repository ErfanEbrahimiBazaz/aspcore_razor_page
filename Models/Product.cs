using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRazorPage.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product name is mandatory!")]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Product code is mandatory!")]
        [Display(Name = "Product Code")]
        public string Code { get; set; }
        [Display(Name = "Product Quantity")]
        public int Qty { get; set; }
    }
}
