using ShareDrive.MasterFolder.CustomButtons;
using ShareDrive.UWP.CustomRenders.CustomButtons;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomAuthenticationButton), typeof(CustomLoginButton))]
namespace ShareDrive.UWP.CustomRenders.CustomButtons
{
    public class CustomLoginButton : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Width = 200;
                Control.BorderRadius = 15;
                Control.Background = new SolidColorBrush(Colors.Beige);
                Control.FontSize = 23;
                Control.BorderBrush = new SolidColorBrush(Colors.Black);
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(5);
            }
        }
    }
}
