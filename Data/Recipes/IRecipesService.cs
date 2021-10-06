using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    using recipes.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRecipesService
    {
        Task<IEnumerable<Recipe>> GetItemsAsync(string query);
        Task<Recipe> GetItemAsync(string id);
        Task AddItemAsync(Recipe item);
        Task UpdateItemAsync(string id, Recipe recipeObj);
        Task DeleteItemAsync(string id);
    }
}
