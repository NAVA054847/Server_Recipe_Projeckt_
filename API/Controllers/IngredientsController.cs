using Core.Entities;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {

     private readonly  IIngredientsService _ingredientsService;

        public IngredientsController(IIngredientsService ingredientsService)
        {
            _ingredientsService = ingredientsService;
        }


        // GET: api/<IngredientsController>
        [HttpGet("GetAll")]
        public List<IngredientsTable> Get()
        {
            return _ingredientsService.GetAllIngredients();
        }

        // GET api/<IngredientsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<IngredientsController>
        [HttpPost ("post")]
        public void Post([FromBody] IngredientsTable ingredients)
        {
            _ingredientsService.AddIngredients(ingredients);
        }

        //// PUT api/<IngredientsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<IngredientsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
