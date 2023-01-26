namespace PersonalFinanceAccounting.Library.Models
{
    /// <summary>
    /// класс лога операций
    /// </summary>
    public class LogOperation
    {
        /// <summary>
        /// идентификатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// идентификатор кошелька
        /// </summary>
        public int IdWallet { get; set; }
        /// <summary>
        /// время проведения транзакции
        /// </summary>
        public DateTime? DateTime { get; set; }
        /// <summary>
        /// имя категории операции
        /// </summary>
        public string? NameCategory { get; set; }
        /// <summary>
        /// сумма транзакции (отрицательное значение - расход, положительное - приход)
        /// </summary>
        public double Sum { get; set; }
    }
}
