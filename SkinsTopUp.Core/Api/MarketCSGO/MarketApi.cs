using SkinsTopUp.Core.Api;
using SkinsTopUp.Core.Constants;
using SkinsTopUp.Core.Entities.MarketResponse;
using SkinsTopUp.Core.ExternalAPI.MarketCSGO;
using System.Web;

namespace SkinsTopUp.Core.ExternalApi.MarketCSGO
{
    internal class MarketApi: ApiRequest, IMarketApi
    {
        private readonly string _token;

        public MarketApi(string token)
        {
            _token = token;
        }

        public async Task<Balance> GetBalanceAsync() => await base.GetRequest<Balance>(ApiUrls.Balance());

        public async Task<Prices> GetPricesAsync(Currency currency) => await base.GetRequest<Prices>(ApiUrls.Prices(currency));

        public Task BuyForAsync() => throw new NotImplementedException();
        public Task Buy() => throw new NotImplementedException();
        public async Task<BuyList> GetBuyListInfoAsync(string[] customIds)
        {
            var queryParams = HttpUtility.ParseQueryString(string.Empty);
            queryParams["key"] = _token;
            foreach (var id in customIds)
            {
                queryParams.Add("custom_id[]", id);
            }

            var baseUrl = ApiUrls.GetListBuyInfoByCustomId();
            var query = queryParams.ToString();
            var url = new Uri(baseUrl + query);

            return await base.GetRequest<BuyList>(url);
        }

        public async Task<BuyItem> GetBuyInfoAsync(string customId)
        {
            var queryParams = HttpUtility.ParseQueryString(string.Empty);
            queryParams["key"] = _token;
            queryParams["custom_id"] = customId;

            var baseUrl = ApiUrls.GetListBuyInfoByCustomId();
            var query = queryParams.ToString();
            var url = new Uri(baseUrl + "?" + query);

            return await base.GetRequest<BuyItem>(url);
        }
    }
}
