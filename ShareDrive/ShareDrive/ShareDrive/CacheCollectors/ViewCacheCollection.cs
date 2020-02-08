using ShareDrive.Pages.Creators;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShareDrive.CacheCollectors
{
    public class ViewCacheCollection
    {
        private static ViewCacheCollection viewCacheCollection;
        private static Dictionary<string, ContentView> views { get; } = new Dictionary<string, ContentView>();
        protected ViewCacheCollection() { }

        public static ViewCacheCollection ViewCache()
        {
            if (viewCacheCollection == null)
            {
                viewCacheCollection = new ViewCacheCollection();
            }

            return viewCacheCollection;
        }

        public static void AddView(ContentView view)
        {
            if (view == null) throw new ArgumentNullException();

            views[view.GetType().Name] = view;
        }

        public static void OffloadView(string viewName)
        {
            if (viewName == null) throw new ArgumentException();

            foreach (var view in views)
            {
                if (view.Key == viewName)
                {
                    views[view.Key] = null;
                    return;
                }
            }
        }

        public static ContentView GetView(string viewName)
        {
            if (viewName == string.Empty) throw new ArgumentException();

            foreach (var view in views)
            {
                if (view.Key == viewName)
                {
                    return view.Value;
                }
            }

            return ViewCreator.tryGetView(viewName);
        }
    }
}
