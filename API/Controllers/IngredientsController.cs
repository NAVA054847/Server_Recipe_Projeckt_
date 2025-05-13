using Core.Entities;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
     private readonly   IIngredientsRepository _ingredientsRepository;

        public IngredientsController(IIngredientsRepository ingredientsRepository)
        {
            _ingredientsRepository = ingredientsRepository;
        }


        // GET: api/<IngredientsController>
        [HttpGet("GetAll")]
        public List<IngredientsTable> Get()
        {
            return _ingredientsRepository.GetAllIngredients();
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
            _ingredientsRepository.AddIngredients(ingredients);
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
