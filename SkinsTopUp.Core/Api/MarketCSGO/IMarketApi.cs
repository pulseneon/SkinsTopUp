using SkinsTopUp.Core.Constants;
using SkinsTopUp.Core.Entities.MarketResponse;

namespace SkinsTopUp.Core.ExternalApi.MarketCSGO
{
    internal interface IMarketApi
    {
        public Task<Prices> GetPricesAsync(Currency currency);
        public Task<Balance> GetBalanceAsync();
        public Task Buy(string hashName, double price, string? customId);
        public Task BuyForAsync(string hashName, double price, string? customId, string tradeUrl);
        public Task<BuyList> GetBuyListInfoAsync(string[] customIds);
        public Task<BuyItem> GetBuyInfoAsync(string customId);
    }
}
