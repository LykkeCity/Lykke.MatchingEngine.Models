using System;
using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Cash operation.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/CashOperation.kt"/>
    public class CashOperation : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string Id { get; set; }

        public string ClientId { get; set; }

        public double Volume { get; set; }

        public string Asset { get; set; }

        public DateTime DateTime { get; set; }

        public List<Fee> Fees { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Id) && Id.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(ClientId) && ClientId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(Asset) && Asset.Length <= MaxStringFieldsLength
                && Volume != 0;
        }
    }
}
