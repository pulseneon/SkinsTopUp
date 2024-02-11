using Xunit;

namespace SkinsTopUp.Core.Tests.SteamApiTests
{
    public class ValidateTradeUrlTest
    {
        [Theory]
        [InlineData("")]
        [InlineData("https://steamcommunity.com/")]
        [InlineData("https://steamcommunity.com/tradeoffer/new/?partner=")]
        [InlineData("https://steamcommunity.com/tradeoffer/new/?partner=1234567&token=")]
        [InlineData("https://steamcomunity.com/tradeoffer/new/?partner=1234567&token=example")]
        public void InvalidTradeUrlTest(string tradeUrl)
        {
            var steam = new Api.Steam.SteamApi();
            var result = steam.ValidateTradeUrl(tradeUrl);

            Assert.False(result, "Invalid trade link");
        }

        [Theory]
        [InlineData("https://steamcommunity.com/tradeoffer/new/?partner=1234567&token=example")]
        public void ValidTradeUrlTest(string tradeUrl)
        {
            var steam = new Api.Steam.SteamApi();
            var result = steam.ValidateTradeUrl(tradeUrl);

            Assert.True(result, "Invalid trade link");
        }
    }
}