using Coronavirus.Resources;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Coronavirus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            AppResources.Culture = new System.Globalization.CultureInfo("tr-TR");
            /*
            CultureInfo.CurrentCulture = new CultureInfo("tr-TR", false);
            CultureInfo.CurrentUICulture = new CultureInfo("tr-TR", false);
            */
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
