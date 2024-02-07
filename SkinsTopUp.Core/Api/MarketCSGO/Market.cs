using Newtonsoft.Json;
using SkinsTopUp.Core.Entities.MarketResponse;
using SkinsTopUp.Core.ExternalAPI.MarketCSGO;
using System.Diagnostics;

namespace SkinsTopUp.Core.ExternalApi.MarketCSGO
{
    internal class Market: IMarket
    {
        private readonly string _token;

        public Market(string token)
        {
            _token = token;
        }

        public async Task<T> GetT<T>(Uri url) where T : class
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
                // todo: logging exceptions
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Balance> GetBalanceAsync() => await GetT<Balance>(ApiUrls.Balance());
    }
}
