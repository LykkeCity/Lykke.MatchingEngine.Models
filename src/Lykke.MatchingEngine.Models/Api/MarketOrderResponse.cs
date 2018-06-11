namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Market order response model.
    /// </summary>
    public class MarketOrderResponse
    {
        public MeStatusCodes Status { get; set; }

        public double Price { get; set; }
    }
}
