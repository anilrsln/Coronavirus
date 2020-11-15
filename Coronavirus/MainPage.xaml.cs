using System;
using System.Threading.Tasks;
using Coronavirus.Models;
using Coronavirus.Provider;
using Coronavirus.Utility;
using Xamarin.Forms;

namespace Coronavirus
{
    public partial class MainPage : ContentPage
    {
        ServiceManager<WorldwideStats> manager = new ServiceManager<WorldwideStats>();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            try
            {
                WorldwideStats result = new WorldwideStats();
                var tt = Task.Run(async delegate {
                    result = await manager.Get(Constraints.GetAllUrl, "/");
                });
                tt.Wait();
                if (result != null)
                {
                    labelAffectedCountriesNum.Text = result.AffectedCountries.ToString();
                    labelPopulationNum.Text = result.Population.ToString();
                    labelCasesNum.Text = result.Cases.ToString();
                    labelDeathNum.Text = result.Deaths.ToString();
                    labelRecoveredNum.Text = result.Recovered.ToString();
                    labelActiveNum.Text = result.Active.ToString();
                    labelCriticalNum.Text = result.Critical.ToString();
                }
            }
            catch(Exception ex) {

            }
        }
    }
}
