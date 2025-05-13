using Core.Entities;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {

        private readonly DataContext _context;

        public RecipeRepository(DataContext context) 
        {
            _context = context;
        }

        public void AddRecipe(RecipeTable recipe)
        {
            _context.RecipeTables.Add(recipe);
            _context.SaveChanges();
        }

        public List<RecipeTable> GetAllRecipe()
        {
          return   _context.RecipeTables.ToList();
        }

        public RecipeTable GetRecipeById(int id)
        {
            return _context.RecipeTables.FirstOrDefault(x => x.IdRecipe == id);
        }
    }
}
