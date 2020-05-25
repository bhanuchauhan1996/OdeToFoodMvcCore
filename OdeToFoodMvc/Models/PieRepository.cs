using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodMvc.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly OdeToFoodDbContext odeToFoodDbContext;

        public PieRepository(OdeToFoodDbContext odeToFoodDbContext)
        {
            this.odeToFoodDbContext = odeToFoodDbContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return odeToFoodDbContext.Pies.Include(c=>c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfWeek
        {
            get
            {
                return odeToFoodDbContext.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int id)
        {
            return odeToFoodDbContext.Pies.FirstOrDefault(p => p.PieId == id);
        }
    }
}
