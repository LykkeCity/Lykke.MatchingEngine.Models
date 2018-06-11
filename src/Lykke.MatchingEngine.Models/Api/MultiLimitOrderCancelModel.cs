namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Multi limit order cancel model.
    /// </summary>
    public class MultiLimitOrderCancelModel
    {
        public string Id { get; set; }

        public string ClientId { get; set; }

        public string AssetPairId { get; set; }

        public bool IsBuy { get; set; }
    }
}