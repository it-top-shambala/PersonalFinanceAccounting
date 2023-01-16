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
        public string? Name { get; set; }
        /// <summary>
        /// idCurrency - идентификатор валюты
        /// </summary>

        public int idCurrency { get; set; }

        /// <summary>
        /// Balance - количество средств в кошельке
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// Метод пополнения кошелька
        /// </summary>
        /// <param name="sum">sum - сумма пополнения</param>
        public void Incoming(double sum)
        {
            Balance += sum;
        }
        /// <summary>
        /// Метод получения из кошелька
        /// </summary>
        /// <param name="sum">sum - сумма получения</param>
        public bool Expensing(double sum)
        {
            if (Balance >= sum)
            {
                Balance -= sum;
                return true;
            }
            return false;
        /// <param name="sum">sum - сумма пополнения</param>
        public void Put(float sum)
        {
            amount += sum;
        }
        /// <summary>
        /// Метод получения из кошелька
        /// </summary>
        /// <param name="sum">sum - сумма получения</param>
        public void Take(float sum)
        {
            if (amount >= sum)
            {
                amount -= sum;
            }
        /// <param name="sum">sum - сумма пополнения</param>
        public void Put(float sum)
        {
            amount += sum;
        }
        /// <summary>
        /// Метод получения из кошелька
        /// </summary>
        /// <param name="sum">sum - сумма получения</param>
        public void Take(float sum)
        {
            if (amount >= sum)
            {
                amount -= sum;
            }
        }
    }
}
