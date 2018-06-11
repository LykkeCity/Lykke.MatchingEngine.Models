using System;
using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Market order fee model.
    /// </summary>
    public class MarketOrderFeeModel
    {
        public FeeType Type { get; set; }

        public double Size { get; set; }

        public string SourceClientId { get; set; }

        public string TargetClientId { get; set; }

        public FeeSizeType SizeType { get; set; }

        public string[] AssetId { get; set; } = Array.Empty<string>();
    }
}
