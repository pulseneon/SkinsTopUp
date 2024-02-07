using SkinsTopUp.Core.Api;
using SkinsTopUp.Core.Entities.MarketResponse;
using SkinsTopUp.Core.ExternalAPI.MarketCSGO;

namespace SkinsTopUp.Core.ExternalApi.MarketCSGO
{
    internal class Market: ApiRequest, IMarket
    {
        private readonly string _token;

        public Market(string token)
        {
            _token = token;
        }

        public async Task<Balance> GetBalanceAsync() => await base.GetRequest<Balance>(ApiUrls.Balance());
    }
}
