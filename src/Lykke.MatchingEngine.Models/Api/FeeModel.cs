using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Fee model.
    /// </summary>
    public class FeeModel
    {
        public FeeType Type { get; set;  }

        public double Size { get; set; }

        public string SourceClientId { get; set; }

        public string TargetClientId { get; set; }

        public FeeSizeType SizeType { get; set; }

        public FeeChargingType ChargingType { get; set; }
    }
}