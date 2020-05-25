﻿using System.Collections.Generic;

namespace OdeToFoodMvc.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Pie> Pies { get; set; }
    }
}