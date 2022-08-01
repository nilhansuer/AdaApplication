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
    public partial class NewUserPage : ContentPage
    {
        public NewUserPage()
        {
            InitializeComponent();
        }

        async void OnClicked_Confirm(object o, EventArgs args)
        {
            // userName = new_username ?????

            await Navigation.PushModalAsync(new MainPage2());

        }
    }
}