using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Depthcharge.Gateway
{
    public class HttpHelper : IHttpHelper
    {
        private readonly IServiceSettings _serviceSettings;

        public HttpHelper(IServiceSettings serviceSettings)
        {
            _serviceSettings = serviceSettings;
        }

        public async Task<string> GetContentForUrlAsync(Uri url)
        {
            HttpResponseMessage response;
            try
            {
                using (var client = new HttpClient())
                {
                    response = await client.GetAsync(url);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;

            }
            return await response.Content.ReadAsStringAsync();

        }

        public async void PatchAsync(string json)
        {
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, _serviceSettings.QueueManagerUrl)
            {
                Content = content
            };

            using (var client = new HttpClient())
            {
                await client.SendAsync(request);
            }
        }

    }
}
