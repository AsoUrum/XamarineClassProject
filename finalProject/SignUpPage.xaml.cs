using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using finalProject.Model;
using SQLite;

namespace finalProject

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private void btnSaveDetails_Clicked(object sender, EventArgs e)
        {
            Client aclient = new Client() { 
                FirstName = fname.Text,
                LastName = lname.Text,
                Email = email.Text,
                Password = password.Text
            };

            using (SQLiteConnection con = new SQLiteConnection(App.DatabaseLocation))
            {
                con.CreateTable<Client>();
                
                int row = con.Insert(aclient);
                if (row > 0)
                {
                    DisplayAlert("success", "Client is Added", "ok");
                }
                else
                {
                    DisplayAlert("failed", "client is not added", "ok");
                }
                fname.Text = "";
                lname.Text = "";
                email.Text = "";
                password.Text = "";
                Navigation.PushAsync(new LogInPage());

            }
        }
    }
}