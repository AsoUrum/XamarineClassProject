using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using finalProject.Model;

namespace finalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        List<Client> clients = new List<Client>();
        public Client aclient;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection con = new SQLiteConnection(App.DatabaseLocation))
            {
                con.CreateTable<Client>();
                clients = con.Table<Client>().ToList();
            }
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            string mail = email.Text;
            string pword = password.Text;

            if (mail == null)
            {
                DisplayAlert("Caution", "Enter your email", "OK");
                return;
            }
            if (pword == null)
            {
                DisplayAlert("Caution", "Enter your password", "OK");
                return;
            }

            bool checker = false;
           

            for (int i = 0; i < clients.Count; i++)
            {
                if (mail == clients[i].Email && pword == clients[i].Password)
                {
                    checker = true;
                    aclient = clients[i];
                }
            }
            if (checker == true)
            {
                email.Text = " ";
                password.Text = " ";
                
                
                Navigation.PushAsync(new DashBoardPage(aclient));
            }
            else
            {
                email.Text = " ";
                password.Text = " ";
                DisplayAlert("Caution", "Invalid Login infor", "OK");
                return;

            }
        }

        private void signUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}