
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinGraphSample.iOS;
using XamarinGraphSample.Views;
[assembly: ExportRenderer(typeof(HomePage), typeof(HomePageRenderer))]
namespace XamarinGraphSample.iOS
{
    class HomePageRenderer : PageRenderer
    {
        HomePage page;
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            page = e.NewElement as HomePage;
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            page.platformParameters = new PlatformParameters(this);
        }
    }
}