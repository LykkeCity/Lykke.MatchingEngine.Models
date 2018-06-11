using System;
using System.Collections.Generic;

namespace Lykke.MatchingEngine.Models.RabbitMqExchanges
{
    /// <summary>
    /// Balance update.
    /// </summary>
    /// <see cref="https://github.com/LykkeCity/MatchingEngine/blob/master/src/main/kotlin/com/lykke/matching/engine/outgoing/messages/BalanceUpdate.kt"/>
    public class BalanceUpdate : IValidatable
    {
        private static int MaxStringFieldsLength { get { return 255; } }

        public string Id { get; set; }

        public string Type { get; set; }

        public DateTime Timestamp { get; set; }

        public List<ClientBalanceUpdate> Balances { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Id) || Id.Length > MaxStringFieldsLength
                || string.IsNullOrWhiteSpace(Type) || Type.Length > MaxStringFieldsLength
                || Balances == null || Balances.Count == 0)
                return false;

            foreach (var balance in Balances)
            {
                if (!balance.IsValid())
                    return false;
            }

            return true;
        }
    }
}
