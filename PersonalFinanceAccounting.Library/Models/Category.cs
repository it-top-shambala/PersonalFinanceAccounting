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
        /// <summary>
        /// Type - тип категории
        /// </summary>
        public string Type { get; set; }
        public Category() { }

    }
}
