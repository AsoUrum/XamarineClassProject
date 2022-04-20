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

    public partial class IngredientsSearchPage : ContentPage
    {

        List<string> sortItems = new List<string>() {
            
            "alcohol",
            "caffeine",
            "energy",
            "calories",
            "calcium",
            "carbohydrates",
            "fiber",
            "iron",
            "magnesium",
            "protein",
            "sodium",
            "sugar"
            
        };


        public IngredientsSearchPage()
        {
            InitializeComponent();

            foreach (string item in sortItems)
            {
                SortPicker.Items.Add(item);
            }
        

        }

        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            string q = query.Text.ToLower();
            string num = number.Text;
            string so = SortPicker.SelectedItem.ToString();

           

            Navigation.PushAsync(new SearchResultPage(q,num,so));
        }
       
    }
}