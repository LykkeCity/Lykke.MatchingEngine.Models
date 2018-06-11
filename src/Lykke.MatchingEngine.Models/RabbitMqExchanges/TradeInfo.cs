using System;
using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Market order trade info.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/TradeInfo.kt"/>
    public class TradeInfo : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string TradeId { get; set; }

        public string MarketClientId { get; set; }

        public double MarketVolume { get; set; }

        public string MarketAsset { get; set; }

        public double Price { get; set; }

        public string LimitClientId { get; set; }

        public double LimitVolume { get; set; }

        public string LimitAsset { get; set; }

        public string LimitOrderId { get; set; }

        public string LimitOrderExternalId { get; set; }

        public DateTime Timestamp { get; set; }

        public List<Fee> Fees { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(MarketClientId) && MarketClientId.Length <= MaxStringFieldsLength
                && MarketVolume != 0
                && !string.IsNullOrWhiteSpace(MarketAsset) && MarketAsset.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(LimitClientId) && LimitClientId.Length <= MaxStringFieldsLength
                && LimitVolume != 0
                && !string.IsNullOrWhiteSpace(LimitAsset) && LimitAsset.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(LimitOrderId) && LimitOrderId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(LimitOrderExternalId) && LimitOrderExternalId.Length <= MaxStringFieldsLength;
        }
    }
}
