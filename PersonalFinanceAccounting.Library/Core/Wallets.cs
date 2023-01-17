using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Core
{
    /// <summary>
    /// Класс для возврата списка кошельков.
    /// </summary>
    public class Wallets
    {
        /// <summary>
        /// Статический метод возврата списка кошельков.
        /// </summary>
        /// <returns>Возвращает список объектов класса Wallet.</returns>
        public static List<Wallet> wallets() { return new List<Wallet>(); }
    }
}
