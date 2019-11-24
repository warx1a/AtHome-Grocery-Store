using AtHomeGroceryStore.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Database
{
    public class CategoryDB
    {

        private string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["database_connection"].ConnectionString;

        public List<Models.Category> getAllCategories()
        {
            SqlCommand cmd;
            List<Models.Category> categories = new List<Models.Category>();

            String query = "SELECT * FROM dbo.Categories";
            using(SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlDataReader dtCats = cmd.ExecuteReader();
                while(dtCats.Read())
                {
                    Models.Category cat = new Models.Category(dtCats.GetFieldValue<int>(0), dtCats.GetFieldValue<string>(1), dtCats.GetFieldValue<string>(2));
                    categories.Add(cat);
                }
            }
            return categories;
        }
    }
}