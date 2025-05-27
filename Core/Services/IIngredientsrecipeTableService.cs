using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Services
{
    public interface IIngredientsrecipeTableService
    {

        List<object> GetIngredientsByRecipeId(int id);

        public void AddIngrediets(int id, List<NewIngredientRecipe> ingredients);
    }
}
