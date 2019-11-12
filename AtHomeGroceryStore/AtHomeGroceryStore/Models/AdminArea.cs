using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class AdminArea
    {
        public List<string> actions { get; set; }

        public AdminArea()
        {
            actions = new List<string>();
            actions.Add("This is an exmaple action");
        }
    }
}