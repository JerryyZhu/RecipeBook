using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class NutrientItem
    {
        [JsonProperty(PropertyName = "label")]
        public string label { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public float quantity { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string unit { get; set; }
    }
}
