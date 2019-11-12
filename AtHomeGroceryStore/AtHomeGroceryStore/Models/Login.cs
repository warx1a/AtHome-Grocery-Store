using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class Login : GenericResponse
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}