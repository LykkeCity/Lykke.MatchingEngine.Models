namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// Cancel mode.
    /// </summary>
    public enum CancelMode : int
    {
        NotEmptySide = 0,
        BothSides = 1,
        SellSide = 2,
        BuySide = 3
    }
}
