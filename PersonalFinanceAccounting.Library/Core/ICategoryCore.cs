using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Core
{
    /// <summary>
    /// Интерфейс категорий расходов и доходов
    /// </summary>
    internal interface ICategoryCore
    {
        /// <summary>
        /// Метод создания категории.
        /// </summary>
        /// <param name="name">Имя категории</param>
        /// <returns>Возвращает объект класса Category</returns>
        Category CreateCategory(string name) { return new(); }
        /// <summary>
        /// Метод изменение имени категории.
        /// </summary>
        /// <param name="oldName">Имя которое нужно изменить.</param>
        /// <param name="newName">Новое имя.</param>
        /// <returns></returns>
        Category UpdateCategory(string oldName, string newName) { return new(); }
        /// <summary>
        /// Метод удаления категории.
        /// </summary>
        /// <param name="name">Имя категории.</param>
        void DeleteCategory(string name) { }
    }
}
