namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс Кошелек
    /// Id - идентификатор кошелька
    /// Name - название кошелька
    /// IdValuta - идентификатор валюты
    /// Amount - количество средств в кошельке
    /// </summary>
    public class Wallet : BaseNotify
    {
        public string? name;
        public int idValuta;
        public float amount;
        public int Id { get; set; }
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name_Wallet");
            }
        }

        public int IdValuta
        {
            get => idValuta;
            set
            {
                idValuta = value;
                OnPropertyChanged("Id_Valuta");
            }
        }
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
