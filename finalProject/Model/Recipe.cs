using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace finalProject.Model
{
    public class Recipe
    {   
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("image")]
        public string image { get; set; }
        [JsonProperty("imageType")]
        public string imageType { get; set; }

    }
}
