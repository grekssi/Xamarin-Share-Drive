using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareDrive.Pages.Authentication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationView : ContentView
    {
        public AuthenticationView()
        {
            InitializeComponent();
        }

        protected async void OnLoginFormAppearing()
        {
            nameLabel.IsVisible = true;
            passwordLabel.IsVisible = true;

            await Task.Run(() => {
                nameLabel.FadeTo(1, 1000, Easing.Linear);
                passwordLabel.FadeTo(1, 1000, Easing.Linear);
            });

            await Task.Run(() =>
            {
                var animateWidthUsername = new Animation(d => username.HeightRequest = d, 1, username.HeightRequest, Easing.CubicInOut);
                var animateWidthPassword = new Animation(d => password.HeightRequest = d, 1, password.HeightRequest, Easing.CubicInOut);

                animateWidthUsername.Commit(username, "BarGraph", 0, 1000);
                animateWidthPassword.Commit(password, "BarGraph", 0, 1000);

            });
            usernameFrame.IsVisible = true;
            passwordFrame.IsVisible = true;
        }

        private void AnimatedClick(object sender, EventArgs e)
        {
            Task.Run(() => {
                registerButton.TranslateTo(1000, 0, 700);
                registerButton.FadeTo(0, 400);
                logInButton.TranslateTo(-1000, 0, 700);
                logInButton.FadeTo(0, 400);
            }).Wait();

            OnLoginFormAppearing();
        }
    }
}