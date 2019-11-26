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
        public decimal productPrice { get; set; }
        public string description { get; set; }
        public List<ProductInfo> reviews { get; set; }
        public int category { get; set; }
        public string productPicture { get; set; }

        public ProductInfo(int code, int category, string name, decimal price, string description, string productPicture = null, List<ProductInfo> reviews = null)
        {
            this.productCode = code;
            this.category = category;
            this.productName = name;
            this.productPrice = price;
            this.description = description;
            this.productPicture = productPicture;
            this.reviews = reviews;
        }
    }
}