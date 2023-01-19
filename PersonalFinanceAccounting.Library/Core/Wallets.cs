using PersonalFinanceAccounting.Library.Db;
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
        public static IEnumerable<Wallet> wallets()
        {
            var list = new PersonalFinanceDbContext();
            return list.GetWallets();
        }
    }
}
