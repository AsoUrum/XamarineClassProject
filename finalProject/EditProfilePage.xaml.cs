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
    public partial class EditProfilePage : ContentPage
    {
        public EditProfilePage()
        {
            InitializeComponent();
        }
        public Client ac ;
        public EditProfilePage(Client aclient)
        {
            InitializeComponent();
            Client cl = aclient;
            ac = aclient;
            fname.Text = cl.FirstName;
            lname.Text = cl.LastName;
            email.Text = cl.Email;
            password.Text = cl.Password;

        }

        private void btnUpdateDetails_Clicked(object sender, EventArgs e)
        {

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                
                ac.FirstName = fname.Text;
                ac.LastName = lname.Text;
                ac.Email = email.Text;
                ac.Password = password.Text;
                conn.CreateTable<Client>();
                int row = conn.Update(ac);
                if (row > 0)
                {
                    DisplayAlert("success", "You information has been updated", "ok");
                    Navigation.PushAsync(new DashBoardPage(ac));
                }
                else
                {
                    DisplayAlert("Failed", "data not Updated", "Ok");
                }

            }



        }
    }
}