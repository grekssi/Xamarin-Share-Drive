using ShareDrive.Pages.Creators;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShareDrive.CacheCollectors
{
    public class PageCacheCollection
    {
        private static PageCacheCollection pageCacheCollection;
        private static Dictionary<string, ContentPage> pages { get; } = new Dictionary<string, ContentPage>();

        protected PageCacheCollection() { }
        
        public static PageCacheCollection PageCache()
        {
            if (pageCacheCollection == null)
            {
                pageCacheCollection = new PageCacheCollection();
            }

            return pageCacheCollection;
        }

        public static void AddPage(ContentPage page)
        {
            if (page == null) throw new ArgumentNullException();

            pages[page.GetType().Name] = page; 
        }

        public static void OffloadPage(string pageName)
        {
            if (pageName == null) throw new ArgumentException();

            foreach (var page in pages)
            {
                if (page.Key == pageName)
                {
                    pages[page.Key] = null;
                    return;
                }
            }
        }

        public static ContentPage GetPage(string pageName)
        {
            if (pageName == string.Empty) throw new ArgumentException();

            foreach (var page in pages)
            {
                if (page.Key == pageName)
                {
                    return page.Value;
                }
            }

            return PageCreator.tryGetInstance(pageName);
        }

        public static void ClearCache()
        {
            pages.Clear();
        }
    }
}
