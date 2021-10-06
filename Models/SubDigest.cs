using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class SubDigest
    {
        [JsonProperty(PropertyName = "label")]
        public string label { get; set; }

        [JsonProperty(PropertyName = "tag")]
        public string tag { get; set; }

        [JsonProperty(PropertyName = "schemaOrgTag")]
        public string schemaOrgTag { get; set; }

        [JsonProperty(PropertyName = "total")]
        public double total { get; set; }

        [JsonProperty(PropertyName = "hasRDI")]
        public bool hasRDI { get; set; }

        [JsonProperty(PropertyName = "daily")]
        public double daily { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string unit { get; set; }
    }
}
