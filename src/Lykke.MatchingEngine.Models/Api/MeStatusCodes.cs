namespace Lykke.MatchingEngine.Models.Api
{
    /// <summary>
    /// ME statuses.
    /// </summary>
    public enum MeStatusCodes
    {
        Ok = 0,

        //validation errors
        BadRequest = 400,
        LowBalance = 401,
        AlreadyProcessed = 402,
        UnknownAsset = 410,
        NoLiquidity = 411,
        NotEnoughFunds = 412,
        Dust = 413,
        ReservedVolumeHigherThanBalance = 414,
        NotFound = 415,
        BalanceLowerThanReserved = 416,
        LeadToNegativeSpread = 417,
        TooSmallVolume = 418,
        InvalidFee = 419,
        InvalidPrice = 420,
        Replaced = 421,
        NotFoundPrevious = 422,
        Duplicate = 430,
        //ME errors
        Runtime = 500,
    }
}
