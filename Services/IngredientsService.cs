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
    public class IngredientsService : IIngredientsService
    {
        private readonly IIngredientsRepository _service;

        public IngredientsService(IIngredientsRepository service)
        {
            _service = service;
        }


        public void AddIngredients(IngredientsTable ingredients)
        {
           _service.AddIngredients(ingredients);
        }

        public List<IngredientsTable> GetAllIngredients()
        {
           return _service.GetAllIngredients();
        }
    }
}
