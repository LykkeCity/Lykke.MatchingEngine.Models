using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Limit order.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/daos/NewLimitOrder.kt"/>
    public class LimitOrder : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string Id { get; set; }

        public string ExternalId { get; set; }

        public string AssetPairId { get; set; }

        public string ClientId { get; set; }

        public double Volume { get; set; }

        public double Price { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStatus Status { get; set; }

        public DateTime? StatusDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime Registered { get; set; }

        public DateTime? LastMatchTime { get; set; }

        public double RemainingVolume { get; set; }

        public bool Straight { get; set; } = true;

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Id) && Id.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(ExternalId) && ExternalId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(AssetPairId) && AssetPairId.Length <= MaxStringFieldsLength
                && !string.IsNullOrWhiteSpace(ClientId) && ClientId.Length <= MaxStringFieldsLength
                && Price > 0
                && Volume != 0;
        }
    }
}
