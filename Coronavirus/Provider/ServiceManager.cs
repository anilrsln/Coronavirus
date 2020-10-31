using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Coronavirus.Utility;
using Newtonsoft.Json;

namespace Coronavirus.Provider
{
    public class ServiceManager<T> where T : class
    {
        internal bool ReqOpResult = false;
        readonly int timeOut = 15;

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(timeOut);
            return client;
        }

        public async Task<T> Get(string endpoint, string param)
        {
            ReqOpResult = false;
            int connectionTryCount = 0;
            var result = default(T);

            try {
                do {
                    connectionTryCount++;
                    try {
                        var client = GetClient();
                        var response = await client.GetAsync(endpoint + param);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                            var retval = await response.Content.ReadAsStringAsync();
                            result = JsonConvert.DeserializeObject<T>(retval);
                            ReqOpResult = true;
                            break;
                        } else {
                            ReqOpResult = false;
                        }
                    } catch (Exception ex) {

                    }
                } while (connectionTryCount < Constraints.ServiceConnectionTryCount);
            } catch (Exception ex) {

            }

            return result;
        }

        public async Task<T> Post<K>(string param, K model, string endpoint)
        {
            int connectionTryCount = 0;
            ReqOpResult = false;
            var result = default(T);

            try {
                do {
                    connectionTryCount++;
                    try {
                        var client = GetClient();
                        var response = await client.PostAsync(endpoint + param,
                            new StringContent(JsonConvert.SerializeObject(model),
                            Encoding.UTF8, "application/json"));

                        if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                            result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                            ReqOpResult = true;
                            break;
                        } else {
                            ReqOpResult = false;
                        }
                    } catch (Exception ex) {

                    }
                } while (connectionTryCount < Constraints.ServiceConnectionTryCount);
            } catch (Exception ex) {

            }

            return result;
        }

        public async Task<T> Put<K>(string param, K model, string endpoint)
        {
            int connectionTryCount = 0;
            ReqOpResult = false;
            var result = default(T);

            try {
                do {
                    connectionTryCount++;
                    try {
                        var client = GetClient();
                        var response = await client.PutAsync(endpoint + param,
                            new StringContent(JsonConvert.SerializeObject(model),
                            Encoding.UTF8, "application/json"));

                        if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                            result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                            ReqOpResult = true;
                            break;
                        } else {
                            ReqOpResult = false;
                        }
                    } catch (Exception ex) {

                    }
                } while (connectionTryCount < Constraints.ServiceConnectionTryCount);
            } catch (Exception ex) {

            }

            return result;
        }
    }
}
