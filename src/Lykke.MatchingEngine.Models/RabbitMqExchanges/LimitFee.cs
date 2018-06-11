namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Fee for limit order trades.
    /// </summary>
    public class LimitFee
    {
        public LimitFeeInstruction Instruction { get; set; }

        public FeeTransfer Transfer { get; set; }
    }
}
