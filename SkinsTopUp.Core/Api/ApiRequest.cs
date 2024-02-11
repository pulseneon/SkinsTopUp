using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SkinsTopUp.Core.Api
{
    public class ApiRequest
    {
        public async Task<T> GetRequest<T>(Uri url) where T : class
        {
            using var client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<T> PostRequest<T>(Uri url) where T : class
        {
            using var client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.PostAsync(url, null);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
