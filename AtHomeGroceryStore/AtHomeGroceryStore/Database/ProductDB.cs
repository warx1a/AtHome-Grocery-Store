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
                conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlDataReader retProds = cmd.ExecuteReader();
                while(retProds.Read())
                {
                    int productCode = retProds.GetFieldValue<int>(0);
                    int categoryId = retProds.GetFieldValue<int>(1);
                    string productName = retProds.GetFieldValue<string>(2);
                    string productDesc = retProds.GetFieldValue<string>(3);
                    decimal productPrice = retProds.GetFieldValue<decimal>(4);
                    string productPicture = retProds.GetFieldValue<string>(5);
                    ProductInfo product = new ProductInfo(productCode, categoryId , productName, productPrice, productDesc, productPicture);
                    products.Add(product);
                }
            }
            return products;
        }

        public ProductInfo getProductInfoById(int id)
        {
            SqlCommand cmd;
            ProductInfo prod;

            String query = "SELECT * FROM dbo.Products WHERE product_id = @id";
            using(SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlParameter p1 = new SqlParameter("@id", System.Data.SqlDbType.Int, 3);
                p1.Value = id;
                cmd.Parameters.Add(p1);
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int productCode = reader.GetFieldValue<int>(0);
                    int categoryId = reader.GetFieldValue<int>(1);
                    string productName = reader.GetFieldValue<string>(2);
                    string productDesc = reader.GetFieldValue<string>(3);
                    decimal productPrice = reader.GetFieldValue<decimal>(4);
                    string productPicture = reader.GetFieldValue<string>(5);
                    prod = new ProductInfo(productCode, categoryId, productName, productPrice, productDesc, productPicture);
                }
            }
            return null;
        }

        public List<ProductInfo> searchProducts(ProductSearch search)
        {
            List<ProductInfo> products = new List<ProductInfo>();
            SqlCommand cmd;
            String query = "SELECT * FROM dbo.Products ";
            if(search.filterCats != null && search.filterCats.Count > 0)
            {
                query += "WHERE ";
                List<int> filteredCats = (from cat in search.filterCats select cat).ToList();
                string filterQuery = "category_id IN (" + String.Join(",", filteredCats) + ")";
                query += filterQuery;
            }
            if(!String.IsNullOrWhiteSpace(search.searchString))
            {
                if(search.filterCats != null)
                {
                    query += " AND ";
                } else
                {
                    query += " WHERE ";
                }
                query += " product_name LIKE %" + search.searchString + "%";
            }
            using(SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int productCode = reader.GetFieldValue<int>(0);
                    int categoryId = reader.GetFieldValue<int>(1);
                    string productName = reader.GetFieldValue<string>(2);
                    string productDesc = reader.GetFieldValue<string>(3);
                    decimal productPrice = reader.GetFieldValue<decimal>(4);
                    string productPicture = reader.GetFieldValue<string>(5);
                    ProductInfo p = new ProductInfo(productCode, categoryId, productName, productPrice, productDesc, productPicture);
                    products.Add(p);
                }
            }
            return products;
        }
    }
}