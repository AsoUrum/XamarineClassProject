using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net.Http;
using finalProject.Model;

namespace finalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchResultPage : ContentPage
    {
        public SearchResultPage()
        {
            InitializeComponent();
            
        }

        public List<Ingredient> allInfor = new List<Ingredient>();
        public SearchResultPage(string a, string b, string c)
        {
            InitializeComponent();

            string q = a;
            string num = b;
            string so = c;

            SearchAllRecipes(a,b,c);

        }


        private async void SearchAllRecipes(string que, string nu, string sor)
        {
       
            string SearchLink = "https://api.spoonacular.com/food/ingredients/search?";
            string searchQuery = "query=" + que;
            string searchNumber = "&number=" + nu;
            string searchSort = "&sort=" + sor;
            string directionAndKey = "&sortDirection=desc&apiKey=961353f7dccf4534a0cde1818d91ea3d";

            string url = SearchLink + searchQuery + searchNumber + searchSort + directionAndKey;
           //string url = "https://api.spoonacular.com/food/ingredients/search?query=banana&number=2&sort=calories&sortDirection=desc&apiKey=961353f7dccf4534a0cde1818d91ea3d";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                var searchResult =  JsonConvert.DeserializeObject<ResultSearch>(response);

                foreach (Ingredient item in searchResult.results)
                {
                    allInfor.Add(item);
                }

               
            }

            listNutrients.ItemsSource = allInfor;

        }
    }

}
