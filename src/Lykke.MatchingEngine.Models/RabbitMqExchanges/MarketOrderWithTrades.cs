using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Container with market order and its trades.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/MarketOrderWithTrades.kt"/>
    public class MarketOrderWithTrades : IValidatable
    {
        public MarketOrder Order { get; set; }

        public List<TradeInfo> Trades { get; set; }

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
