using System.Collections.Generic;
using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Market order model.
    /// </summary>
    public class MarketOrderModel
    {
        public string Id  { get; set; }

        public string ClientId  { get; set; }

        public string AssetPairId { get; set; }

        public OrderAction OrderAction { get; set; }

        public double Volume { get; set; }

        public bool Straight { get; set; }

        public double? ReservedLimitVolume { get; set; }

        public MarketOrderFeeModel Fee { get; set; }

        public IReadOnlyList<MarketOrderFeeModel> Fees { get; set; } = new List<MarketOrderFeeModel>(0);
    }
}
