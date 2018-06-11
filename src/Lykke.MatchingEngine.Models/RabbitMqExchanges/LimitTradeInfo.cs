using System;
using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Limit order trade info.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/LimitTradeInfo.kt"/>
    public class LimitTradeInfo : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string TradeId { get; set; }

        public string ClientId { get; set; }

        public string Asset { get; set; }

        public double Volume { get; set; }

        public double Price { get; set; }

        public DateTime Timestamp { get; set; }

        public string OppositeOrderId { get; set; }

        public string OppositeOrderExternalId { get; set; }

        public string OppositeAsset { get; set; }

        public string OppositeClientId { get; set; }

        public double OppositeVolume { get; set; }

        public List<LimitFee> Fees { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(ClientId) && ClientId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(Asset) && Asset.Length <= MaxStringFieldsLength
                && Volume != 0
                && Price > 0
                && !string.IsNullOrWhiteSpace(OppositeClientId) && OppositeClientId.Length <= MaxStringFieldsLength
                && OppositeVolume != 0
                && !string.IsNullOrWhiteSpace(OppositeAsset) && OppositeAsset.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(OppositeOrderId) && OppositeOrderId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(OppositeOrderExternalId) && OppositeOrderExternalId.Length <= MaxStringFieldsLength;
        }
    }
}
