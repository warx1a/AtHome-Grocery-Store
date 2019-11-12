using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class PaymentMethod
    {
        public string cardType { get; set; }
        public string cardNumber { get; set; }
        public int csc { get; set; }
        public string cardName { get; set; }
    }
}