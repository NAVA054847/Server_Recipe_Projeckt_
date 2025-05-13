using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
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

        //מה זה אומר ?? לטפל פה
        //לבדוק אופציה של רשימה של מילונים
        public void AddIngrediets(int id, List<int> ingredients)
        {
            //foreach (var ingredient in ingredients)
            //{
            //    IngredientsrecipeTable table = new IngredientsrecipeTable();
            //    table.IdRecipeIngredientsRecipe = id;
            //    table.IdIngredientsIngredientsRecipe = ingredient;
            //    table.UnitsIngredientsRecipe = "1";

            //    _Context.IngredientsrecipeTables.Add(table);
            //}

        }

        public List<IngredientsrecipeTable> GetIngredientsByRecipeId(int id)
        {
            return _Context.IngredientsrecipeTables.ToList();
        }
    }
}
