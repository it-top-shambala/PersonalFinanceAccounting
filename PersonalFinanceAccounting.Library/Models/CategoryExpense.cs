namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс категорий расходов
    /// </summary>
    public class CategoryExpense
    {
        /// <summary>
        ///  Id - идентификатор категории
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Category - назавание категории
        /// </summary>
        public string Category { get; set; }
    }
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged("CategoryExpense");
            }
        }
    }
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
