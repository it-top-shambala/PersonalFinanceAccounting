namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс Валюта
    /// Id - идентификатор валюты
    /// Name - название валюты
    /// Code - код валюты
    /// </summary>
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
