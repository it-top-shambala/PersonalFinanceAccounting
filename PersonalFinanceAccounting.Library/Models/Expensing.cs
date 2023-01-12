namespace PersonalFinanceAccounting.Library.Models
{
    internal class Expensing : Notify
    {
        public int Id { get; set; }
        public DateTime TimeExp { get; set; }
        public int IdWallet { get; set; }
        public int IdCatExp { get; set; }
        public float SumExp { get; set; }
    }
}
