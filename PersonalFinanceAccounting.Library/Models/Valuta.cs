namespace PersonalFinanceAccounting.Library.Models
{
    public class Valuta : BaseNotify
    {
        public string? name;
        public int code;
        public int Id { get; set; }
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name_Valuta");
                OnNotify($"Валюта: {name}");
            }
        }
        public int Code
        {
            get => code;
            set
            {
                code = value;
                OnPropertyChanged("Code_Valuta");
            }
        }
    }
}
