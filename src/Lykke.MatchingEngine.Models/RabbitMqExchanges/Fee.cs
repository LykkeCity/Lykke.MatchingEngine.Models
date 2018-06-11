namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Fee.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/daos/fee/Fee.kt"/>
    public class Fee
    {
        public FeeInstruction Instruction { get; set; }

        public FeeTransfer Transfer { get; set; }
    }
}
