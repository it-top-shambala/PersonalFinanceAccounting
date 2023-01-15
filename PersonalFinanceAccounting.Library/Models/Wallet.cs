namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс Кошелек
    /// </summary>
    public class Wallet : BaseNotify
    {
        public string? name;
        public int idValuta;
        public float amount;
        /// <summary>
        ///  Id - идентификатор кошелька
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  Name - название кошелька
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// IdValuta - идентификатор валюты
        /// </summary>
        public int IdValuta
        {
            get => idValuta;
            set
            {
                idValuta = value;
                OnPropertyChanged("Id_Valuta");
            }
        }
        /// <summary>
        /// Amount - количество средств в кошельке
        /// </summary>
        public float Amount
        {
            get => amount;
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }
        /// <summary>
        /// Метод пополнения кошелька
        /// </summary>
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
