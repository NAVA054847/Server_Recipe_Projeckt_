using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Repositories
{
    public interface IRecipeRepository
    {
        List<RecipeTable> GetAllRecipe();
        RecipeTable GetRecipeById(int id);
        void AddRecipe(RecipeTable recipe);
    }
}
