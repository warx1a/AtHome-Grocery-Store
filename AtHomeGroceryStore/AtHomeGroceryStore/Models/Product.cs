using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class Product : GenericResponse
    {
        public int productCode { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productPrice { get; set; }
        public List<ProductReview> reviews { get; set; }
    }
}