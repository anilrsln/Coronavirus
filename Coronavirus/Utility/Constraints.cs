using Xamarin.Essentials;

namespace Coronavirus.Utility
{
    public class Constraints
    {
        public static double DeviceWidth = DeviceDisplay.MainDisplayInfo.Width;

        public static double DeviceHeight = DeviceDisplay.MainDisplayInfo.Height;

        public static int ServiceConnectionTryCount = 3;

        public static string BaseUrl = "https://corona.lmao.ninja/";

        public static string GetAllUrl = BaseUrl + "v3/covid-19/all";

        public static string GetCountriesUrl = BaseUrl + "v2/countries?sort=country";
    }
}
