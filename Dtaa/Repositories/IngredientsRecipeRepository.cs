using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
//using Core.Repositories
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class IngredientsRecipeRepository : IIngredientsrecipeTableRepository
    {
        private readonly DataContext _Context;

        public IngredientsRecipeRepository(DataContext context)
        {
            _Context = context;
        }


        public void AddIngrediets(int id, List<Dictionary<int, string>> ingredients)
        {

            foreach (var dictionary in ingredients)
            {

                foreach (var ingr in dictionary)
                {

                    IngredientsrecipeTable ingredients1 = new IngredientsrecipeTable();
                    ingredients1.IdRecipeIngredientsRecipe = id;
                    ingredients1.IdIngredientsIngredientsRecipe = ingr.Key;
                    ingredients1.UnitsIngredientsRecipe = ingr.Value;
                    _Context.IngredientsrecipeTables.Add(ingredients1);
                    _Context.SaveChanges();

                }
            }


        }

        public List<object> GetIngredientsByRecipeId(int id)
        {
            return _Context.IngredientsrecipeTables.
                Where(ir=>ir.IdRecipeIngredientsRecipe==id)
          .Include(ir => ir.IdIngredientsIngredientsRecipeNavigation)
           .Select(ir => new 
           {
               Name = ir.IdIngredientsIngredientsRecipeNavigation.NameIngredients,
               Units = ir.UnitsIngredientsRecipe,
           })
           .ToList<object>();

        }
    }
}
