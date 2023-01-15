namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс категорий приходов
    /// </summary>
    public class CategoryRefill : BaseNotify
    {
        /// <summary>
        ///  Id - идентификатор категории
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Category - назавание категории
        /// </summary>
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
