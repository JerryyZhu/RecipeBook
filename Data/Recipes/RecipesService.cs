using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;
using recipes.Models;

namespace RecipeBook.Data
{
    public class RecipesService : IRecipesService
    {
        private Container _container;

        public RecipesService(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddItemAsync(Recipe recipe)
        {
            await this._container.CreateItemAsync<Recipe>(recipe, new PartitionKey(recipe.id));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<Recipe>(id, new PartitionKey(id));
        }

        public async Task<Recipe> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<Recipe> response = await this._container.ReadItemAsync<Recipe>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<Recipe>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Recipe>(new QueryDefinition(queryString));
            List<Recipe> results = new List<Recipe>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync(string id, Recipe recipe)
        {
            await this._container.UpsertItemAsync<Recipe>(recipe, new PartitionKey(id));
        }
    }
}
