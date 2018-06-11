using Newtonsoft.Json;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Client balance update.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/BalanceUpdate.kt"/>
    public class ClientBalanceUpdate : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        [JsonProperty(PropertyName = "Id")]
        public string ClientId { get; set; }

        public string Asset { get; set; }

        public double OldBalance { get; set; }

        public double NewBalance { get; set; }

        public double OldReserved { get; set; }

        public double NewReserved { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(ClientId) && ClientId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(Asset) && Asset.Length <= MaxStringFieldsLength
                && (OldBalance != NewBalance || OldReserved != NewReserved);
        }
    }
}
