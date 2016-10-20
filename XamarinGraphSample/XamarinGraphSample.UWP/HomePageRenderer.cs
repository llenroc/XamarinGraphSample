using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinGraphSample.UWP;
using XamarinGraphSample.Views;

[assembly: ExportRenderer(typeof(HomePage), typeof(HomePageRenderer))]

namespace XamarinGraphSample.UWP
{
    class HomePageRenderer : PageRenderer
    {
        private HomePage page;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Page> e)
        {
            base.OnElementChanged(e);
            page = e.NewElement as HomePage;
            page.platformParameters = new PlatformParameters();

        }

       
    }
}
