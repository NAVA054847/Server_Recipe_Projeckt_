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
    public class IngredientsrecipeService : IIngredientsrecipeTableService
    {
        private readonly IIngredientsrecipeTableRepository _ingredientsrecipeTableRepository;

        public IngredientsrecipeService(IIngredientsrecipeTableRepository ingredientsrecipeTableRepository)
        {
            _ingredientsrecipeTableRepository = ingredientsrecipeTableRepository;
        }

        //לא לכח לממש!!!
        //חסר לנו הבנה מה בדיוק צריכה להיות הפפונקציה
        public void AddIngrediets(int id, List<int> ingredients)
        {
            throw new NotImplementedException();
        }

        public List<IngredientsrecipeTable> GetIngredientsByRecipeId(int id)
        {
            List<IngredientsrecipeTable> list = _ingredientsrecipeTableRepository.GetIngredientsByRecipeId(id);
            
            List<IngredientsrecipeTable> listreturn = new List<IngredientsrecipeTable>();


            foreach (var ingredient in list)
            {
                if (ingredient.IdRecipeIngredientsRecipe == id)
                    listreturn.Add(ingredient);
            }

            return listreturn;
        }
    }
}
