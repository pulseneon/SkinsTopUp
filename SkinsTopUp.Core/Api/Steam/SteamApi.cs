using SkinsTopUp.Core.Entities.SteamResponse;
using SkinsTopUp.Core.Enums;
using System.Text.RegularExpressions;

namespace SkinsTopUp.Core.Api.Steam
{
    public class SteamApi : ApiRequest, ISteamApi
    {
        public async Task<Price> GetPrice(string hashName, Currency currency = Currency.RUB) => await base.GetRequest<Price>(ApiUrls.Price(hashName, currency));

        public bool ValidateTradeUrl(string tradeUrl)
        {
            var pattern = @"^https:\/\/steamcommunity\.com\/tradeoffer\/new\/\?partner=\d+&token=[a-zA-Z]+$";

            return Regex.IsMatch(tradeUrl, pattern); 
        }
    }
}
