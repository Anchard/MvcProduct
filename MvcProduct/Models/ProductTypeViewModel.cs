using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcProduct.Models
{
    public class ProductTypeViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList Types { get; set; }
        public string ProductType { get; set; }
        public string SearchString { get; set; }
    }
}