namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Limit order mass cancel model.
    /// </summary>
    public class LimitOrderMassCancelModel
    {
        public string Id { get; set; }

        public string ClientId { get; set; }

        public string AssetPairId { get; set; }

        public bool? IsBuy { get; set; }
    }
}
