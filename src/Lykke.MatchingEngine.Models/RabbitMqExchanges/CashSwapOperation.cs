using System;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Cash operation.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/CashSwapOperation.kt"/>
    public class CashSwapOperation : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string Id { get; set; }

        public DateTime DateTime { get; set; }

        public string ClientId1 { get; set; }

        public double Volume1 { get; set; }

        public string Asset1 { get; set; }

        public string ClientId2 { get; set; }

        public double Volume2 { get; set; }

        public string Asset2 { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Id) && Id.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(ClientId1) && ClientId1.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(Asset1) && Asset1.Length <= MaxStringFieldsLength
                && Volume1 != 0
                && !string.IsNullOrWhiteSpace(ClientId2) && ClientId2.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(Asset2) && Asset2.Length <= MaxStringFieldsLength
                && Volume2 != 0
                && ClientId1 != ClientId2;
        }
    }
}
