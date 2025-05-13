using Core.Entities;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly DataContext _context;

        public IngredientsRepository(DataContext context)
        {
           _context = context;
        }

        public void AddIngredients(IngredientsTable ingredients)
        {
           _context.IngredientsTables.Add(ingredients);
            _context.SaveChanges();
        }


        public List<IngredientsTable> GetAllIngredients()
        {
            return _context.IngredientsTables.ToList();
        }





    }
}
