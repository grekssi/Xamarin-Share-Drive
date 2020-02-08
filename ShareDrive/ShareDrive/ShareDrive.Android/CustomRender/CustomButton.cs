using Android.Content;
using Android.Provider;
using Java.Util;
using ShareDrive.Droid.CustomRender;
using ShareDrive.MasterFolder.CustomButtons;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.PlatformConfiguration;

[assembly: ExportRenderer(typeof(CustomAuthenticationButton), typeof(CustomButton))]
namespace ShareDrive.Droid.CustomRender
{
    class CustomButton : Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer
    {
        public CustomButton(Context context) : base(context)
        {
        }

        protected void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                Control.SetShadowLayer(5, 3, 3, Color.Black.ToAndroid());

                 
            }
        }
    }
}