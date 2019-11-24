using AtHomeGroceryStore.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Database
{
    public class ProductDB
    {

        private string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["database_connection"].ConnectionString;

        public List<ProductInfo> getAllProducts()
        {
            SqlCommand cmd;
            List<ProductInfo> products = new List<ProductInfo>();

            String query = "SELECT * FROM dbo.Products";
            using(SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                cmd = new SqlCommand(query, conn);
                SqlDataReader retProds = cmd.ExecuteReader();
                while(retProds.Read())
                {
                    int productCode = retProds.GetFieldValue<int>(0);
                    string productName = retProds.GetFieldValue<string>(1);
                    double productPrice = retProds.GetFieldValue<double>(2);
                    string productDesc = retProds.GetFieldValue<string>(3);
                    ProductInfo product = new ProductInfo(productCode, productName, productPrice, productDesc);
                    products.Add(product);
                }
            }
            return products;
        }
    }
}