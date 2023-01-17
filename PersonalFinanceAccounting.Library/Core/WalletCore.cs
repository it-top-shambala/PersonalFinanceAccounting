using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Core
{
    /// <summary>
    /// Класс для работы с кошельком.
    /// </summary>
    public class WalletCore
    {
        /// <summary>
        /// Приватный список расходных категорий.
        /// </summary>
        private List<Category> _categoriesExpense;
        /// <summary>
        /// Приватный список доходных категорий.
        /// </summary>
        private List<Category> _categoriesIncome;
        /// <summary>
        /// Приватный кошелек.
        /// </summary>
        private Wallet _wallet;
        /// <summary>
        /// Приватный список валют.
        /// </summary>
        private List<Currency> _currency;
        /// <summary>
        /// Конструктор по умолчанию WalletCore.
        /// </summary>
        public WalletCore() { }
        /// <summary>
        /// Метод возврата списка расходных категорий.
        /// </summary>
        /// <returns>Возвращает список объектов класса Category</returns>
        public List<Category> CategoriesExpense() { return _categoriesExpense; }
        /// <summary>
        /// Метод возврата списка доходных категорий.
        /// </summary>
        /// <returns>Возвращает список объектов класса Category.</returns>
        public List<Category> CategoryIncome() { return _categoriesIncome; }
        /// <summary>
        /// Метод возврата списка валют.
        /// </summary>
        /// <returns>Возвращает список объектов класса Currwncy.</returns>
        public List<Currency> Сurrencies() { return _currency; }
        /// <summary>
        /// Метод создания кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        /// <param name="currency">Валюта кошелька.</param>
        /// <param name="balance">Баланс кошелька.</param>
        /// <returns>Возвращает объект класса Wallet.</returns>
        public Wallet CreateWallet(string name, Currency currency, float balance) { return _wallet; }
        /// <summary>
        /// Метод изменения имени кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        /// <returns>Возвращает объект класса Wallet.</returns>
        public Wallet UpdateWallet(string name) { return _wallet; }
        /// <summary>
        /// Метод удаления кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        public void DeleteWallet(string name) { }
        /// <summary>
        /// Метод возврата баланса кошелька.
        /// </summary>
        /// <param name="name">Имя кошелька.</param>
        /// <returns>Возвращает (double) баланс кошелька.</returns>
        public double BalanceWallet(string name) { return _wallet.Balance;}
    }
}
