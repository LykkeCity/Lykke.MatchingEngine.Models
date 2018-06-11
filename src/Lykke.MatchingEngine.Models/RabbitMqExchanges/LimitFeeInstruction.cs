using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Fee instruction for limit order trades.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/daos/fee/NewLimitOrderFeeInstruction.kt"/>
    public class LimitFeeInstruction
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FeeType Type { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FeeSizeType SizeType { get; set; }

        public double? Size { get; set; }

        public string SourceClientId { get; set; }

        public string TargetClientId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FeeSizeType? MakerSizeType { get; set; }

        public double? MakerSize { get; set; }

        public double? MakerFeeModificator { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FeeSizeType? TakerSizeType { get; set; }

        public double? TakerSize { get; set; }
    }
}
