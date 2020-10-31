using Newtonsoft.Json;

namespace Coronavirus.Models
{
    public class WorldwideStats
    {
        [JsonProperty(PropertyName = "updated")]
        public string UpdatedDateTime;

        [JsonProperty(PropertyName = "cases")]
        public long Cases;

        [JsonProperty(PropertyName = "todayCases")]
        public long TodayCases;

        [JsonProperty(PropertyName = "deaths")]
        public long Deaths;

        [JsonProperty(PropertyName = "todayDeaths")]
        public long TodayDeaths;

        [JsonProperty(PropertyName = "recovered")]
        public long Recovered;

        [JsonProperty(PropertyName = "todayRecovered")]
        public long TodayRecovered;

        [JsonProperty(PropertyName = "active")]
        public long Active;

        [JsonProperty(PropertyName = "critical")]
        public long Critical;

        [JsonProperty(PropertyName = "casesPerOneMillion")]
        public long CasesPerOneMillion;

        [JsonProperty(PropertyName = "deathsPerOneMillion")]
        public long DeathsPerOneMillion;

        [JsonProperty(PropertyName = "tests")]
        public long Tests;

        [JsonProperty(PropertyName = "testsPerOneMillion")]
        public long TestsPerOneMillion;

        [JsonProperty(PropertyName = "population")]
        public long Population;

        [JsonProperty(PropertyName = "oneCasePerPeople")]
        public long OneCasePerPeople;

        [JsonProperty(PropertyName = "oneDeathPerPeople")]
        public long OneDeathPerPeople;

        [JsonProperty(PropertyName = "oneTestPerPeople")]
        public long OneTestPerPeople;

        [JsonProperty(PropertyName = "activePerOneMillion")]
        public long ActivePerOneMillion;

        [JsonProperty(PropertyName = "recoveredPerOneMillion")]
        public long RecoveredPerOneMillion;

        [JsonProperty(PropertyName = "criticalPerOneMillion")]
        public long CriticalPerOneMillion;

        [JsonProperty(PropertyName = "affectedCountries")]
        public long AffectedCountries;
    }
}