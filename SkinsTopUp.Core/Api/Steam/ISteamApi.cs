using SkinsTopUp.Core.Entities.SteamResponse;
using SkinsTopUp.Core.Enums;

namespace SkinsTopUp.Core.Api.Steam
{
    public interface ISteamApi
    {
        Task<Price> GetPrice(string hashName, Currency currency);
        bool ValidateTradeUrl(string tradeUrl);
    }
}
