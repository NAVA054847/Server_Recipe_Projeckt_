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

        
        public void AddIngrediets(int id, List<Dictionary<int, string>> ingredients)
        {
           _ingredientsrecipeTableRepository.AddIngrediets(id,ingredients);

        }



        public List<object> GetIngredientsByRecipeId(int id)
        {
            List<object> list = _ingredientsrecipeTableRepository.GetIngredientsByRecipeId(id);

            //List<object> listreturn = new List<object>();


            //foreach (var ingredient in list)
            //{
            //    if (ingredient.idrecipe == id)
            //        listreturn.Add(ingredient);
            //}

            return list;
        }
    }
}
