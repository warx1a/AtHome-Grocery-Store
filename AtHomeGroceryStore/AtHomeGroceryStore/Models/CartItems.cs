using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtHomeStore.Models
{
    public class CartItems
    {
        public string ItemId { get; set; }

        public int Amount { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
