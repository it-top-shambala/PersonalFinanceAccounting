using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Core
{
    /// <summary>
    /// Класс для обработки расходных и доходных транзакций
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Статический метод проведения доходных транзакций.
        /// </summary>
        /// <param name="category">Категория транзакции.</param>
        /// <param name="summ">Сумма транзакции.</param>
        /// <param name="wallet">Кошелек.</param>
        public static void Incom (string categoryName, double summ, string walletName)
        {

        }
        /// <summary>
        /// Статический метод проведения расходных транзакций.
        /// </summary>
        /// <param name="category">Категория транзакции.</param>
        /// <param name="summ">Сумма транзакции.</param>
        /// <param name="wallet">Кошелек.</param>
        public static void Expense (string categoryName, double summ, string walletName) { }
    }
}
