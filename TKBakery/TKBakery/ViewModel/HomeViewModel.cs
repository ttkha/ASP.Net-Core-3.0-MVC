using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TKBakery.Models;

namespace TKBakery.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
