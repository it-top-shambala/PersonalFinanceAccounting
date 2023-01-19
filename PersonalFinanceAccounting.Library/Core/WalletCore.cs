using PersonalFinanceAccounting.Library.Db;
using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Core
{
    /// <summary>
    /// Класс для работы с кошельком.
    /// </summary>
    public class WalletCore
    {
        private static Wallet GetWallet(string nameWallet) //TODO
        {
            var list = new PersonalFinanceDbContext();
            var wallets = list.GetWallets();
            var wallet = from w in wallets
                         where w.Name == nameWallet
                         select w;
            return wallet.ToList()[0];
        }
        /// <summary>
        /// Метод возврата списка расходных категорий.
        /// </summary>
        /// <returns>Возвращает список объектов класса Category</returns>
        public static IEnumerable<Category> CategoriesExpense()
        {
            var list = new PersonalFinanceDbContext();
            return list.GetCategoryExpenses();
        }
        /// <summary>
        /// Метод возврата списка доходных категорий.
        /// </summary>
        /// <returns>Возвращает список объектов класса Category.</returns>
        public static IEnumerable<Category> CategoryIncome()
        {
            var list = new PersonalFinanceDbContext();
            return list.GetCategoryIncomings();
        }
        /// <summary>
        /// Метод возврата списка валют.
        /// </summary>
        /// <returns>Возвращает список объектов класса Currwncy.</returns>
        public static IEnumerable<Currency> Сurrencies()
        {
            var list = new PersonalFinanceDbContext();
            return list.GetCurrencies();
        }
        /// <summary>
        /// Метод создания кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        /// <param name="currency">Валюта кошелька.</param>
        /// <param name="balance">Баланс кошелька.</param>
        /// <returns>Возвращает объект класса Wallet.</returns>
        public static Wallet CreateWallet(string nameWallet, string currencyName, float balance)
        {
            var list = new PersonalFinanceDbContext();
            var wallet = new Wallet(nameWallet, list.GetIdCurrency(currencyName), balance);
            if (list.CreateWallet(wallet)) return wallet;
            else return new Wallet();//TODO
        }
        /// <summary>
        /// Метод изменения имени кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        /// <returns>Возвращает объект класса Wallet.</returns>
        public static Wallet UpdateWallet(string oldName, string newName)
        {
            var wallet = GetWallet(oldName);
            wallet.Name = newName;
            // TODO
            return wallet;
        }
        /// <summary>
        /// Метод удаления кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        public static void DeleteWallet(string nameWallet)
        {
            var list = new PersonalFinanceDbContext();
            var wallet = GetWallet(nameWallet).Id;
            list.DeleteWallet(wallet);
        }
        /// <summary>
        /// Метод возврата баланса кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        /// <returns>Возвращает (double) баланс кошелька.</returns>
        public static double BalanceWallet(string nameWallet)
        {
            var wallet = GetWallet(nameWallet);
            return wallet.Balance;
        }
    }
}
