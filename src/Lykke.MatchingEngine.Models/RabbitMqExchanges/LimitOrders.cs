using System.Linq;
using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Limit orders container.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/LimitOrdersReport.kt"/>
    public class LimitOrders : IValidatable
    {
        public List<LimitOrderWithTrades> Orders { get; set; }

        public bool IsValid()
        {
            return Orders.All(o => o.IsValid());
        }
    }
}
