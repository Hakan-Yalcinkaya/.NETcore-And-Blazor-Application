using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }
        [Required (ErrorMessage ="Bu alan Zorunludur")]
        public string ProductName { get; set; }
        [Required (ErrorMessage = "Bu alan Zorunludur")]
        public string QuantityPerUnit { get; set; }
        [Required(ErrorMessage  ="Bu alan Zorunludur")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Bu alan Zorunludur")]
        [Range (0,50)]
        public int UnitsInStock { get; set; }
    }
}
