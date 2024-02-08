﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinsTopUp.Core.Entities.MarketResponse
{

    public class BuyList
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ItemsData Data { get; set; }
    }

    public class ItemsData
    {
        [JsonProperty("custom_id")]
        public CustomId CustomId { get; set; }
    }

    public class CustomId
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonProperty("classid")]
        public string Classid { get; set; }

        [JsonProperty("instance")]
        public string Instance { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("send_until")]
        public object SendUntil { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("paid")]
        public double Paid { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("for")]
        public string For { get; set; }

        [JsonProperty("trade_id")]
        public object TradeId { get; set; }
    }
}
