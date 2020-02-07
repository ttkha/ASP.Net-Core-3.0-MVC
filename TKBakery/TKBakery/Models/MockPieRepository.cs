using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TKBakery.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie> {
              new Pie{ PieId=1, Name="Strawberry Pie", Price=15.95M, ShortDescription="make from Strawberry", LongDescription="Good job on the report! I think the executives will like it! "},
              new Pie{ PieId=2, Name="Cheese Cake", Price=20M, ShortDescription="make from Cheese", LongDescription="Good job on the report! I think the executives will like it! "},
              new Pie{ PieId=3, Name="Rhubarb Pie", Price=50M, ShortDescription="make from Rhubarb", LongDescription="Good job on the report! I think the executives will like it! "},
              new Pie{ PieId=4, Name="Pumpkin Pie", Price=1M, ShortDescription="make from Pumpkin", LongDescription="Good job on the report! I think the executives will like it! "},
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
