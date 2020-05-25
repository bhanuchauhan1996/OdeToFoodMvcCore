using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodMvc.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Fruit Pies",CategoryDescription="All fruit pie"},
                 new Category{CategoryId=2,CategoryName="Chesse Cakes",CategoryDescription="Made up of Cakes"}
            };
    }
}
