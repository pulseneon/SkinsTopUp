using SkinsTopUp.Core.Constants;

namespace SkinsTopUp.Core.ExternalAPI.MarketCSGO
{
    /// <summary>
    /// Class for retrieving MarketCSGO API URLs
    /// </summary>
    public static class ApiUrls
    {
        private const string Host = "https://market.csgo.com/api/v2";
        private static readonly Uri BaseUri = new(Host);

        public static Uri Prices(Currency currency)
        {
            string pricesPath = "/api/v2/prices/";
            return new Uri(BaseUri, $"{pricesPath}{currency}.json");
        }

        public static Uri Balance()
        {
            string balancePath = "/get-money";
            return new Uri(BaseUri, balancePath);
        }

        public static Uri BuyFor()
        {
            string buyPath = "/buy-for";
            return new Uri(BaseUri, buyPath);
        }

        public static Uri GetListBuyInfoByCustomId()
        {
            string listPath = "/get-list-buy-info-by-custom-id";
            return new Uri(BaseUri, listPath);
        }

        public static Uri GetBuyInfoByCustomId()
        {
            string infoPath = "/get-buy-info-by-custom-id";
            return new Uri(BaseUri, infoPath);
        }

    }
}
