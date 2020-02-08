using ShareDrive.MasterFolder.CustomEntries;
using ShareDrive.UWP.CustomRenders.CustomEntries;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomAuthenticationEntry), typeof(TransparentEntry))]
namespace ShareDrive.UWP.CustomRenders.CustomEntries
{
    public class TransparentEntry : EntryRenderer
    {
       protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
       {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = new SolidColorBrush(Colors.Transparent);
                Control.BorderBrush = new SolidColorBrush(Colors.Transparent);
                Control.FontSize = 23;
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0, 0, 0, 0);
            }
       }
    }
}
