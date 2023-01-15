namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс категорий расходов
    /// </summary>
    public class CategoryExpense : BaseNotify
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
                OnPropertyChanged("CategoryExpense");
            }
        }
    }
}
