using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Ingredient
    {
        [JsonProperty(PropertyName = "text")]
        public string text { get; set; }

        [JsonProperty(PropertyName = "measure")]
        public string measure { get; set; }

        [JsonProperty(PropertyName = "food")]
        public string food { get; set; }

        [JsonProperty(PropertyName = "foodCategory")]
        public string foodCategory { get; set; }

        [JsonProperty(PropertyName = "foodId")]
        public string foodId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public double quantity { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public double weight { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string image { get; set; }
    }
}
