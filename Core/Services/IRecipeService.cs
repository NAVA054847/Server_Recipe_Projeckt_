﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Services
{
    public interface IRecipeService
    {
        List<RecipeTable> GetAllRecipe();
        RecipeTable GetRecipeById(int id);
        int AddRecipe(RecipeTable recipe);
    }
}
