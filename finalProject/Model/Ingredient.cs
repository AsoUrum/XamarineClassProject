using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace finalProject.Model
{
    public class Ingredient
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("image")]
        public string image { get; set; }
        


    }
}
