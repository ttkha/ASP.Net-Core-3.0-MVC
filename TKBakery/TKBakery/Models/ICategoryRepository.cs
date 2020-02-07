using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TKBakery.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategoryies { get; }
    }

}
