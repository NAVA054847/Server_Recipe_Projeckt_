using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Services
{
    public interface IIngredientsService
    {
        List<IngredientsTable> GetAllIngredients();
        void AddIngredients(IngredientsTable ingredients);
    }
}
