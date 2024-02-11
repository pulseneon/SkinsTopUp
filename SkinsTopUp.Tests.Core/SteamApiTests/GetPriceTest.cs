using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using SkinsTopUp.Core.Api.Steam;
using SkinsTopUp.Core.Entities.SteamResponse;
using SkinsTopUp.Core.Enums;
using Xunit;
using Xunit.Repeat;

namespace SkinsTopUp.Core.Tests.SteamApiTests
{
    public class GetPriceTest
    {
        private static List<string> _validHashNames = new List<string>
        {
            "ESL One Cologne 2015 Legends (Foil)",
            "M4A1-S | Atomic Alloy (Factory New)",
            "StatTrak\u2122 M4A4 | Magnesium (Minimal Wear)",
            "\u2605 Ursus Knife | Safari Mesh (Well-Worn)"
        };

        private Random _random = new Random();

        [Theory]
        [Repeat(10)]
        public async Task ValidSkinsGetPriceAsync(int iterationNumber)
        {
            var hashName = _validHashNames[_random.Next(_validHashNames.Count)];
            var currency = EnumExtensions.GetRandomEnumValue<Currency>();

            var steam = new SteamApi();
            var result = await steam.GetPrice(hashName, currency);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task ValidSkinsGetPriceWithoutPriceAsync()
        {
            var hashName = _validHashNames[_random.Next(_validHashNames.Count)];

            var steam = new SteamApi();
            var result = await steam.GetPrice(hashName);

            Assert.True(result.Success);
        }
    }
}
