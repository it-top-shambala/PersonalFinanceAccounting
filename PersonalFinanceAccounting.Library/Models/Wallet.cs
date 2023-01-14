namespace PersonalFinanceAccounting.Library.Models
{
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
                OnNotify($"В кошельке: {amount}");
            }
        }
    }
}
