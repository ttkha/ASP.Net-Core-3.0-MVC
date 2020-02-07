using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TKBakery.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategoryies => new List<Category> {
            new Category{ CategoryId=1, CategoryName="Fruit pies", Description="All-fruit"},
            new Category{ CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy"},
            new Category{ CategoryId=3, CategoryName="Seasonal pies", Description="All-Seasonal"},
        };
    }
}
