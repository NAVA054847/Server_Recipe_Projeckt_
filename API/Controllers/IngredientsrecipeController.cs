using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsrecipeController : ControllerBase
    {

        private readonly IIngredientsrecipeTableService _ingredientsrecipeTableService;

        public IngredientsrecipeController(IIngredientsrecipeTableService ingredientsrecipeTableService)
        {
            _ingredientsrecipeTableService = ingredientsrecipeTableService;
        }



        // GET: api/<IngredientsrecipeController>
        [HttpGet ("{id}")]
        public List<object> GetingredientByRecipeId(int id)
        {
            return _ingredientsrecipeTableService.GetIngredientsByRecipeId(id);
        }

        //// GET api/<IngredientsrecipeController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}



        ////
        //לטפל בפונקציה הזאת
        ///


        // POST api/<IngredientsrecipeController>
        [HttpPost("AddIngredients")]
        public void Post(int id, List<Dictionary<int, string>> ingredients)
        {
            _ingredientsrecipeTableService.AddIngrediets(id, ingredients);
        }

        //// PUT api/<IngredientsrecipeController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<IngredientsrecipeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
