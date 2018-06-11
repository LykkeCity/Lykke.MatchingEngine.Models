using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Multi limit order item model.
    /// </summary>
    public class MultiOrderItemModel
    {
        public string Id { get; set; }

        public OrderAction OrderAction { get; set; }

        public double Volume { get; set; }

        public double Price { get; set; }

        public LimitOrderFeeModel Fee { get; set; }

        public string OldId { get; set; }
    }
}