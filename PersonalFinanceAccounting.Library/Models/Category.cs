namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// Класс категорий приходов
    /// </summary>
    public class Category
    {
        /// <summary>
        ///  Id - идентификатор категории
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name - назавание категории
        /// </summary>
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }
        public Category()
        {
        }
    }
}
