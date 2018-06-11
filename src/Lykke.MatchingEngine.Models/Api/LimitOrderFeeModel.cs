using Lykke.MatchingEngine.Models.Common;

namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Limit order fee model.
    /// </summary>
    public class LimitOrderFeeModel
    {
        public FeeType Type { get; set; }

        public double MakerSize { get; set; }

        public double TakerSize { get; set; }

        public string SourceClientId { get; set; }

        public string TargetClientId { get; set; }

        public FeeSizeType MakerSizeType { get; set; }

        public FeeSizeType TakerSizeType { get; set; }

        public string[] AssetId { get; set; }

        public double MakerFeeModificator { get; set; }
    }
}
