using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class ProductInfo : GenericResponse
    {
        public int productCode { get; set; }
        public string productName { get; set; }
        public string productPrice { get; set; }
        public string description { get; set; }
        public List<ProductInfo> reviews { get; set; }
    }
}