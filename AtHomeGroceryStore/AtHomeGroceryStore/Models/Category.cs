using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class Category
    {

        public string categoryName { get; set; }
        public string categoryPicture { get; set; }
        public int categoryId { get; set; }

        public Category(int id, string name, string picture)
        {
            this.categoryName = name;
            this.categoryId = id;
            this.categoryPicture = picture;
        }

    }
}