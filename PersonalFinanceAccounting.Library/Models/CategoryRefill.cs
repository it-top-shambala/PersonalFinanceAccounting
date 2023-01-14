namespace PersonalFinanceAccounting.Library.Models
{
    public class CategoryRefill : BaseNotify
    {
        public int Id { get; set; }
        public string? category { get; set; }
        public string Category
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged("CategoryRefill");
                OnNotify($"Выбрана категория: {category}");
            }
        }
    }
}
