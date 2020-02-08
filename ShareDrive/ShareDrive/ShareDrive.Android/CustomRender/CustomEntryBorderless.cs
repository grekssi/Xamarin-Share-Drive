using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ShareDrive.Droid.CustomRender;
using ShareDrive.MasterFolder.CustomEntries;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomAuthenticationEntry), typeof(CustomEntryBorderless))]
namespace ShareDrive.Droid.CustomRender
{
    class CustomEntryBorderless : EntryRenderer
    {
        public CustomEntryBorderless(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
            }
        }
    }
}