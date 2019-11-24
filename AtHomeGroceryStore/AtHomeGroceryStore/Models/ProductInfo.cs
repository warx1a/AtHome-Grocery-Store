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
        public double productPrice { get; set; }
        public string description { get; set; }
        public List<ProductInfo> reviews { get; set; }

        public ProductInfo(int code, string name, double price, string description, List<ProductInfo> reviews = null)
        {
            this.productCode = code;
            this.productName = name;
            this.productPrice = price;
            this.description = description;
            this.reviews = reviews;
        }
    }
}