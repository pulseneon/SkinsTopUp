﻿using SkinsTopUp.Core.Entities.MarketResponse;
using SkinsTopUp.Core.Enums;

namespace SkinsTopUp.Core.Api.MarketCSGO
{
    internal interface IMarketApi
    {
        public Task<Prices> GetPricesAsync(Currency currency);
        public Task<Balance> GetBalanceAsync();
        public Task<BuyResult> Buy(string hashName, double price, string? customId);
        public Task<BuyResult> BuyForAsync(string hashName, double price, string? customId, string tradeUrl);
        public Task<BuyList> GetBuyListInfoAsync(string[] customIds);
        public Task<BuyItem> GetBuyInfoAsync(string customId);
    }
}
