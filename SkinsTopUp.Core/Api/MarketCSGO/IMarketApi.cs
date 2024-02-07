using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinsTopUp.Core.ExternalApi.MarketCSGO
{
    internal interface IMarketApi
    {
        public Task<double> GetMoneyAsync();
    }
}
