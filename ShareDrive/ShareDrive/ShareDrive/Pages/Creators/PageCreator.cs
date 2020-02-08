using ShareDrive.Pages.Authentication.Pages;
using Xamarin.Forms;

namespace ShareDrive.Pages.Creators
{
    public static class PageCreator
    {
        public static ContentPage tryGetInstance(string pageName)
        {
            switch (pageName)
            {
                case "LoginPage": return new LoginPage();
                case "MainPage": return new MainPage();

                default:
                    return null;
            }
        }
    }
}
