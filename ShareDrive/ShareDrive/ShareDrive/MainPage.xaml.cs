using ShareDrive.CacheCollectors;
using ShareDrive.Pages.Creators;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShareDrive
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            PageCacheCollection.ClearCache();
            InitializePage();
        }

        private void InitializePage()
        {
            InitializeComponent();
            PageCacheCollection.AddPage(this);
            GetInitialPage();
        }

        public async void GetInitialPage()
        {
            var modalPage = PageCreator.tryGetInstance("LoginPage");
            try
            {
                await Navigation.PushModalAsync(modalPage);
            }
            catch (Exception)
            {
                await DisplayAlert("Invalid page", "Failed", "OK");
            }
        }
    }
}
