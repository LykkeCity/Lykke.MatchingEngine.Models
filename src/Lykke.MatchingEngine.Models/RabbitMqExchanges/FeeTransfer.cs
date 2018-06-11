using System;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Fee transfer.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/daos/FeeTransfer.kt"/>
    public class FeeTransfer
    {
        public string ExternalId { get; set; }

        public string FromClientId { get; set; }

        public string ToClientId { get; set; }

        public DateTime DateTime { get; set; }

        public double Volume { get; set; }

        public string Asset { get; set; }

        public double? FeeCoef { get; set; }
    }
}
