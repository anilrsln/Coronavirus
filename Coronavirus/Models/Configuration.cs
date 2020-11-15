using Newtonsoft.Json;

namespace Coronavirus.CustomDependency
{
    public class Configuration
    {
        public Endpoint Endpoint;
        public Credential credential;
    }

    public class Endpoint
    {
        [JsonProperty(PropertyName = "baseUrl")]
        public string BaseUrl;
        [JsonProperty(PropertyName = "getAllUrl")]
        public string GetAllUrl;
        [JsonProperty(PropertyName = "getCountriesUrl")]
        public string GetCountriesUrl;
    }

    public class Credential
    {
        [JsonProperty(PropertyName = "username")]
        public string username;
        [JsonProperty(PropertyName = "password")]
        public string password;
    }
}
