using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class ProductReview
    {
        public int reviewRating { get; set; }
        public string reivewDescription { get; set; }
        public int productID { get; set; }
    }
}