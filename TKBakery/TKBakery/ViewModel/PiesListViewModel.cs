using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TKBakery.Models;

namespace TKBakery.ViewModel
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
