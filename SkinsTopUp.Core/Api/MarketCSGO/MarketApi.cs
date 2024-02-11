using SkinsTopUp.Core.Entities.MarketResponse;
using SkinsTopUp.Core.Enums;
using System.Web;

namespace SkinsTopUp.Core.Api.MarketCSGO
{
    public class MarketApi: ApiRequest, IMarketApi
    {
        private readonly string _token;

        public MarketApi(string token)
        {
            _token = token;
        }

        public async Task<Balance> GetBalanceAsync() => await base.GetRequest<Balance>(ApiUrls.Balance());

        public async Task<Prices> GetPricesAsync(Currency currency = Currency.RUB) => await base.GetRequest<Prices>(ApiUrls.Prices(currency));

        public async Task<BuyResult> Buy(string hashName, double price, string? customId)
        {
            var queryParams = HttpUtility.ParseQueryString(string.Empty);
            queryParams["key"] = _token;
            queryParams["hash_name"] = hashName;
            queryParams["price"] = price.ToString();
            
            if (customId != null)
            {
                queryParams["custom_id"] = customId;
            }

            var baseUrl = ApiUrls.Buy();
            var query = queryParams.ToString();
            var url = new Uri(baseUrl + query);

            return await base.PostRequest<BuyResult>(url);
        }

        public async Task<BuyResult> BuyForAsync(string hashName, double price, string? customId, string tradeUrl)
        {
            var queryParams = HttpUtility.ParseQueryString(string.Empty);
            queryParams["key"] = _token;
            queryParams["hash_name"] = hashName;
            queryParams["price"] = price.ToString();

            if (customId != null)
            {
                queryParams["custom_id"] = customId;
            }

            tradeUrl = tradeUrl.Replace("https://steamcommunity.com/tradeoffer/new/?", string.Empty);

            var baseUrl = ApiUrls.Buy();
            var query = queryParams.ToString();
            var url = new Uri(baseUrl + query + tradeUrl);

            return await base.PostRequest<BuyResult>(url);
        }

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
