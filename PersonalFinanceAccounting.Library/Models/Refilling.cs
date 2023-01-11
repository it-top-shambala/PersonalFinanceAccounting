namespace PersonalFinanceAccounting.Library.Models
{
    internal class Refilling : Notify
    {
        public int Id { get; set; }
        public DateTime TimeRef { get; set; }
        public int IdWallet { get; set; }
        public int IdCatRef { get; set; }
        public float SumRef { get; set; }
    }
}
