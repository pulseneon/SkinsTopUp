using Newtonsoft.Json;

namespace SkinsTopUp.Core.Entities.MarketResponse
{
    public class Balance
    {
        [JsonProperty("money")]
        public double Money { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
