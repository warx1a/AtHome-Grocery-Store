using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class Profile
    {
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string profilePath { get; set; }
        public List<BillingInfo> billing { get; set; }
        public List<PaymentMethod> paymentMethods { get; set; }
    }
}