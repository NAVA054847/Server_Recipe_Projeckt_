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

        List<IngredientsrecipeTable> GetIngredientsByRecipeId(int id);

        void AddIngrediets(int id, List<int> ingredients);
    }
}
