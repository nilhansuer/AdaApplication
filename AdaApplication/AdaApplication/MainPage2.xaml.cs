using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdaApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        async void OnClicked_User(object o, EventArgs args)
        {
            if (userName.Text == "admin" && userPassword.Text == "123")
            {
                await Navigation.PushModalAsync(new HomePage());
            }
            else
            {
                Task task = DisplayAlert("OOPS!", "Your username or password is wrong!", "OK");
            }
        }

        async void OnClicked_NewUser(object o, EventArgs args)
        {

            await Navigation.PushModalAsync(new NewUserPage());
        }
    }
}