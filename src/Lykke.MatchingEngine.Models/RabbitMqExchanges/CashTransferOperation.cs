using System;
using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Cash transfer operation.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/CashTransferOperation.kt"/>
    public class CashTransferOperation : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string Id { get; set; }

        public string FromClientId { get; set; }

        public string ToClientId { get; set; }

        public DateTime DateTime { get; set; }

        public double Volume { get; set; }

        public string Asset { get; set; }

        public List<Fee> Fees { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Id) && Id.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(FromClientId) && FromClientId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(ToClientId) && ToClientId.Length <= MaxStringFieldsLength
                && FromClientId != ToClientId
                && !string.IsNullOrWhiteSpace(Asset) && Asset.Length <= MaxStringFieldsLength
                && Volume > 0;
        }
    }
}
