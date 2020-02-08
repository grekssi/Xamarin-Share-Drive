using ShareDrive.CacheCollectors;
using ShareDrive.Pages.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareDrive.Pages.Authentication.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ImageInitial.FadeTo(1, 1250);

            Task.Run(() => { initialLoginPageLayout.Children.Add(ViewCacheCollection.GetView("AuthenticationView")); });
        }

        private void CustomAuthenticationButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}