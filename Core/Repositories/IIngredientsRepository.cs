﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Repositories
{
    public interface IIngredientsRepository
    {
        List<IngredientsTable> GetAllIngredients();
        void AddIngredients(IngredientsTable ingredients);    
    }
}
