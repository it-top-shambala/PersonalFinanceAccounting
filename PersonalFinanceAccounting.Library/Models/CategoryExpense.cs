namespace PersonalFinanceAccounting.Library.Models
{
    public class CategoryExpense : BaseNotify
    {
        public int Id { get; set; }
        public string? category { get; set; }
        public string Category
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged("CategoryExpense");
                OnNotify($"Выбрана категория: {category}");
            }
        }
    }
}
