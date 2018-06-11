using System;
using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Order book.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/OrderBook.kt"/>
    public class OrderBook : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string AssetPair { get; set; }

        public bool IsBuy { get; set; }

        public DateTime Timestamp { get; set; }

        public List<VolumePrice> Prices { get; set; }

        public bool IsValid()
        {
            if (AssetPair == null || AssetPair.Length > MaxStringFieldsLength)
                return false;

            if (Prices != null)
                foreach (var price in Prices)
                {
                    if (!price.IsValid())
                        return false;
                }

            return true;
        }
    }
}
