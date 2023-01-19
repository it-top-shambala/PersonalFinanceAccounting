namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс Кошелек
    /// </summary>
    public class Wallet
    {
        /// <summary>
        ///  Id - идентификатор кошелька
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  Name - название кошелька
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// IdCurrancy - идентификатор валюты
        /// </summary>
        public int IdCurrency { get; set; }

        /// <summary>
        /// Amount - количество средств в кошельке
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// Метод пополнения кошелька
        /// </summary>
        /// <param name="sum">sum - сумма пополнения</param>
        public Wallet(string name, int id, double balance)
        {
            Name = name;
            Id = id;
            Balance = balance;
        }

        public Wallet()
        {
        }
    }
}
