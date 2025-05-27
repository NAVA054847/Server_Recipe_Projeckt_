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


        public void AddIngrediets(int id, List<NewIngredientRecipe> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                IngredientsrecipeTable ingredients1 = new IngredientsrecipeTable();
                ingredients1.IdRecipeIngredientsRecipe = id;
                ingredients1.IdIngredientsIngredientsRecipe = ingredient.Id; // שינוי כאן
                ingredients1.UnitsIngredientsRecipe = ingredient.Unit;     // שינוי כאן
                _Context.IngredientsrecipeTables.Add(ingredients1);
            }
            _Context.SaveChanges(); // העברנו את ה-SaveChanges מחוץ ללולאה
        }

        public List<object> GetIngredientsByRecipeId(int id)
        {
            return _Context.IngredientsrecipeTables.
                Where(ir => ir.IdRecipeIngredientsRecipe == id)
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
