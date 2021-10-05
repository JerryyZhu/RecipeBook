using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using recipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        
        public RecipesController()
        {
            
        }

        // GET: api/<RecipesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // POST api/<RecipesController>
        [HttpPost]
        public IActionResult Post([FromForm] Recipe recipeObj)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Record deleted");
        }
    }
}
