using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Repositories
{
    public interface IIngredientsrecipeTableRepository
    {

        List<IngredientsrecipeTable> GetIngredientsByRecipeId(int id);

        void AddIngrediets(int id, List<int>ingredients);
    }
}
