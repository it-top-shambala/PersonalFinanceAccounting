namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс категорий приходов
    /// Id - идентификатор категории
    /// Category - назавание категории
    /// </summary>
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
            }
        }
    }
}
