using System;
using System.Collections.Generic;
using System.Text;

namespace finalProject.Model
{
    public class ResultSearch
    {
        public List<Ingredient> results { get; set; }
        //public Ingredient[] results { get; set; }
        public string offset { get; set; }
        public string number { get; set; }
        public string totalResults { get; set; }

      
       
    }
}
