using ShareDrive.Pages.Authentication;
using ShareDrive.Pages.Authentication.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShareDrive.Pages.Creators
{
    public static class ViewCreator
    {
        public static ContentView tryGetView(string viewName)
        {
            switch (viewName)
            {
                case "AuthenticationView": return new AuthenticationView();

                default:
                    return null;
            }
        }
    }
}
