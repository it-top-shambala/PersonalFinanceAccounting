using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Core
{
    /// <summary>
    /// Класс для работы с доходными категориями. наследуеться от интерфейса категорий
    /// </summary>
    public class CategoryIncomeCore : ICategoryCore
    {
        /// <summary>
        /// Статический метод создание новой категории досхода.
        /// </summary>       
        /// <param name="name">Имя категории.</param>
        /// <returns>Возвращает объект класса Category.</returns>
        public static Category CreateCategory(string name) { return new(); }
        /// <summary>
        /// Статический метод изменения имени категории досхода.
        /// </summary>
        /// <param name="oldName">Имя которое нужно поменять.</param>
        /// <param name="newName">Новое имя.</param>
        /// <returns>Возвращает объект класса Category.</returns>
        public static Category UpdateCategory(string oldName, string newName) { return new(); }
        /// <summary>
        /// Статический метод удаления категории досхода.
        /// </summary>
        /// <param name="name">Имя категории.</param>
        public static void DeleteCategory(string name) { }
    }
}
