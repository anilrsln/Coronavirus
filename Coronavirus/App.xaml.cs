using Coronavirus.CustomDependency;
using Coronavirus.Resources;
using Coronavirus.Utility;
using Xamarin.Forms;

namespace Coronavirus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppResources.Culture = new System.Globalization.CultureInfo("tr-TR");
            Constraints.Configuration = DependencyService.Get<IFileStorage>().Read<Configuration>("config.json");
            MainPage = new MainPage();
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
