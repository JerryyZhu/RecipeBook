using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Models
{
    using Newtonsoft.Json;
    using RecipeBook.Models;

    public class Recipe
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "uri")]
        public string uri { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string label { get; set; }
        [JsonProperty(PropertyName = "image")] 
        public string image { get; set; }
        [JsonProperty(PropertyName = "source")]
        public string source { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }

        [JsonProperty(PropertyName = "shareAs")]
        public string shareAs { get; set; }

        [JsonProperty(PropertyName = "calories")]
        public double calories { get; set; }

        [JsonProperty(PropertyName = "healthLabels")]
        public List<string> healthLabels { get; set; }

        [JsonProperty(PropertyName = "cautions")]
        public List<string> cautions { get; set; }

        [JsonProperty(PropertyName = "ingredientLines")]
        public List<string> ingredientLines { get; set; }

        [JsonProperty(PropertyName = "ingredients")]
        public List<Ingredient> ingredients { get; set; }

        [JsonProperty(PropertyName = "totalWeight")]
        public double totalWeight { get; set; }

        [JsonProperty(PropertyName = "totalTime")]
        public double totalTime { get; set; }

        [JsonProperty(PropertyName = "dishType")]
        public List<string> dishType { get; set; }

        [JsonProperty(PropertyName = "cuisineType")]
        public List<string> cuisineType { get; set; }

        [JsonProperty(PropertyName = "mealType")]
        public List<string> mealType { get; set; }

        [JsonProperty(PropertyName = "totalNutrients")]
        public Dictionary<string, NutrientItem> totalNutrients { get; set; }

        [JsonProperty(PropertyName = "totalDaily")]
        public Dictionary<String, DailyIntakeItem> totalDaily { get; set; }

        [JsonProperty(PropertyName = "digest")]
        public List<Digest> digest { get; set; }

        [JsonProperty(PropertyName = "IsComplete")]
        public string IsComplete { get; set; }


    }
}
