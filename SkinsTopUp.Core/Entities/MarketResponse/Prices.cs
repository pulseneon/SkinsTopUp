using Newtonsoft.Json;

namespace SkinsTopUp.Core.Entities.MarketResponse
{
    public class Prices
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }
    }
}
