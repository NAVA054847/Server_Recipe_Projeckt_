using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class IngredientsrecipeTable
{
    public int IdIngredientsRecipe { get; set; }

    public int? IdRecipeIngredientsRecipe { get; set; }

    public int? IdIngredientsIngredientsRecipe { get; set; }

    public string? UnitsIngredientsRecipe { get; set; }

    public virtual IngredientsTable? IdIngredientsIngredientsRecipeNavigation { get; set; }

    public virtual RecipeTable? IdRecipeIngredientsRecipeNavigation { get; set; }
}
