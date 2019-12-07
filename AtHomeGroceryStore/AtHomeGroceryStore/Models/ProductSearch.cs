using AtHomeGroceryStore.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class ProductSearch
    {

        private ProductDB productDB = new ProductDB();
        private CategoryDB categoryDB = new CategoryDB();

        public List<int> filterCats { get; set; }
        public List<Category> availableCats { get; set; }
        public List<ProductInfo> availableProducts { get; set; }
        public List<ProductInfo> filteredProducts { get; set; }
        public List<string> activeFilters { get; set; }

        public string searchString { get; set; }

        public int? infoCode { get; set; }
        public int filterCategory { get; set; }
        public string filterOperation { get; set; }

        public ProductSearch()
        {
            this.filteredProducts = new List<ProductInfo>();
            this.availableProducts = productDB.getAllProducts();
            this.availableCats = categoryDB.getAllCategories();
            this.searchString = "";
            this.activeFilters = new List<string>();
        }

    }
}