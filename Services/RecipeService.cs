using Core.Entities;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RecipeService : IRecipeService
    {

        private readonly IRecipeRepository _recipeRepository;

        public RecipeService (IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }


        public void AddRecipe(RecipeTable recipe)
        {
           _recipeRepository.AddRecipe(recipe);
        }

        public List<RecipeTable> GetAllRecipe()
        {
         return  _recipeRepository.GetAllRecipe();
        }

        public RecipeTable GetRecipeById(int id)
        {
           return _recipeRepository.GetRecipeById(id);
        }
    }
}
