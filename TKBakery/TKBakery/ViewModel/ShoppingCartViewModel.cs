using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TKBakery.Models;

namespace TKBakery.ViewModel
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart{ get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }

}
