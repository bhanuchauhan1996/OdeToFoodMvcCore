using System;
using System.Collections.Generic;

namespace OdeToFoodMvc.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OdeToFoodDbContext odeToFoodDbContext;

        public CategoryRepository(OdeToFoodDbContext odeToFoodDbContext)
        {
            this.odeToFoodDbContext = odeToFoodDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return odeToFoodDbContext.Categories;
            }
        }
    }
}
