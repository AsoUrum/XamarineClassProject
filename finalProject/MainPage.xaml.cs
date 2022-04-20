using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net.Http;
//using System.Collections.ObjectModel;
using finalProject.Model;


namespace finalProject
{
   
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            GetAllRecipes();
        }

        private async void GetAllRecipes()
        {
            string url = "https://api.spoonacular.com/recipes/complexSearch?apiKey=961353f7dccf4534a0cde1818d91ea3d";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                var listRecipes = JsonConvert.DeserializeObject<Result>(response);

                carouselRecipes.ItemsSource = listRecipes.results;

              
            }
        }






    }
}
