using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Container with limit order and its trades.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/LimitOrderWithTrades.kt"/>
    public class LimitOrderWithTrades : IValidatable
    {
        public LimitOrder Order { get; set; }

        public List<LimitTradeInfo> Trades { get; set; }

        public bool IsValid()
        {
            if (!Order.IsValid())
                return false;

            if (Trades != null)
                foreach (var trade in Trades)
                {
                    if (!trade.IsValid())
                        return false;
                }

            return true;
        }
    }
}
