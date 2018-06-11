namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Order data.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/OrderBook.kt"/>
    public class VolumePrice : IValidatable
    {
        public double Volume { get; set; }

        public double Price { get; set; }

        public bool IsValid()
        {
            return Volume != 0 && Price >= 0;
        }
    }
}
