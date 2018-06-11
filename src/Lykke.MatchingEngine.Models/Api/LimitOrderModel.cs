using System.Collections.Generic;
using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Limit order model.
    /// </summary>
    public class LimitOrderModel
    {
        public string Id { get; set; }

        public string ClientId { get; set; }

        public string AssetPairId { get; set; }

        public OrderAction OrderAction { get; set; }

        public double Volume { get; set; }

        public double Price { get; set; }

        public bool CancelPreviousOrders { get; set; }

        public LimitOrderFeeModel Fee { get; set; }

        public IReadOnlyList<LimitOrderFeeModel> Fees { get; set; } = new List<LimitOrderFeeModel>(0);
    }
}
