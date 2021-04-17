using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uic_1st_app.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uic_1st_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            activitypinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconheight;


            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
                }
        void SignInProcedure (object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())

            {
                DisplayAlert("Login", "Login Success", "Ok");
                App.UserDatabase.SaveUser(user);
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, empty username or password", "Ok");
            }
        }
    }
} 