using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Models
{
    using Newtonsoft.Json;
    public class Recipe
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "image")] 
        public string image { get; set; }
        [JsonProperty(PropertyName = "source")]
        public string source { get; set; }

        [JsonProperty(PropertyName = "sourceUrl")]
        public string sourceUrl { get; set; }

        [JsonProperty(PropertyName = "calories")]
        public string calories { get; set; }

        [JsonProperty(PropertyName = "healthLabels")]
        public string healthLabels { get; set; }

        [JsonProperty(PropertyName = "cautions")]
        public string cautions { get; set; }

        [JsonProperty(PropertyName = "ingredientLines")]
        public string ingredientLines { get; set; }

        [JsonProperty(PropertyName = "ingredients")]
        public string ingredients { get; set; }

        [JsonProperty(PropertyName = "totalWeight")]
        public string totalWeight { get; set; }

        [JsonProperty(PropertyName = "totalTime")]
        public string totalTime { get; set; }

        [JsonProperty(PropertyName = "dishType")]
        public string dishType { get; set; }

        [JsonProperty(PropertyName = "cuisineType")]
        public string cuisineType { get; set; }

        [JsonProperty(PropertyName = "totalNutrients")]
        public string totalNutrients { get; set; }

        [JsonProperty(PropertyName = "totalDaily")]
        public string totalDaily { get; set; }

        [JsonProperty(PropertyName = "digest")]
        public string digest { get; set; }


        [JsonProperty(PropertyName = "IsComplete")]
        public string IsComplete { get; set; }


    }
}
