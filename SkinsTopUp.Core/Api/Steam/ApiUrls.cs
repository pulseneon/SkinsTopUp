﻿using SkinsTopUp.Core.Enums;

namespace SkinsTopUp.Core.Api.Steam
{
    internal static class ApiUrls
    {
        public static Uri Price(string nameHash, Currency currency)
        {
            string itemPath = $"https://steamcommunity.com/market/priceoverview/?&currency={(int)currency}&appid={(int)SteamApp.CSGO}&market_hash_name={nameHash}";
            return new Uri(itemPath);
        }
    }
}
