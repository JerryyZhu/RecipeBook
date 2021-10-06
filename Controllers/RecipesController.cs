using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Data;
using RecipeBook.Helper;
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
        private IRecipesService _recipeDbContext;
        public RecipesController(IRecipesService recipesService)
        {
            _recipeDbContext = recipesService;
        }

        // GET: api/<RecipesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var items = await _recipeDbContext.GetItemsAsync("SELECT * FROM c");
            return Ok();
        }

        // POST api/<RecipesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Recipe recipeObj)
        {
            string id = (RecipeUtils.createIdFromUri(recipeObj.uri));
            recipeObj.id = id;

            var findRecipe = await _recipeDbContext.GetItemAsync(id);

            if (findRecipe != null)
            {
                return StatusCode(StatusCodes.Status409Conflict, "Item already exists");
            }

            await _recipeDbContext.AddItemAsync(recipeObj);

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
