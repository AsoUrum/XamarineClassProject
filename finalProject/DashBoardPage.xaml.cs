using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using finalProject.Model;

namespace finalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardPage : ContentPage
    {
        
        public DashBoardPage()
        {
            InitializeComponent();
        }
        public Client clGeneral;
        public DashBoardPage(Client acleint)
        {
            InitializeComponent();
            Client cl = acleint;
            clGeneral = acleint;
            profileName.Text = "Welcom " + cl.FirstName.ToString().ToUpper() + " " + cl.LastName.ToString().ToUpper();

        }

        private void btnCheckRecipes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btnUpdate_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditProfilePage(clGeneral));
        }

        private void btnSearchDetails_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IngredientsSearchPage());
        }

        private void btnSignOut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogInPage());
        }
    }
}