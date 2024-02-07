using SkinsTopUp.Core.Entities.MarketResponse;

namespace SkinsTopUp.Core.ExternalApi.MarketCSGO
{
    internal interface IMarket
    {
        public Task<Balance> GetBalanceAsync();
    }
}
