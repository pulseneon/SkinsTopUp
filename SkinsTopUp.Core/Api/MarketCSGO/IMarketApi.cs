using SkinsTopUp.Core.Constants;
using SkinsTopUp.Core.Entities.MarketResponse;

namespace SkinsTopUp.Core.ExternalApi.MarketCSGO
{
    internal interface IMarketApi
    {
        public Task<Prices> GetPricesAsync(Currency currency);
        public Task<Balance> GetBalanceAsync();
        public Task BuyForAsync();
        public Task Buy();
        public Task<BuyList> GetBuyListInfoAsync(string[] customIds);
        public Task<BuyItem> GetBuyInfoAsync(string customId);
    }
}
