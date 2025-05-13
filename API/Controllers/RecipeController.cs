using Core.Entities;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
   



    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {


        private readonly IRecipeService _recipeService;

        public RecipeController (IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        // GET: api/<RecipeController>
        [HttpGet ("GetAll")]
        public List<RecipeTable> GetAll()
        {
            return _recipeService.GetAllRecipe() ;
        }

        // GET api/<RecipeController>/5
        [HttpGet("GetById{id}")]
        public RecipeTable GetRecipeById(int id)
        {
            return _recipeService.GetRecipeById(id) ;
        }

        // POST api/<RecipeController>
        [HttpPost]
        public void Post([FromBody] RecipeTable recipe)
        {
            _recipeService.AddRecipe(recipe) ;
        }

        //// PUT api/<RecipeController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RecipeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
