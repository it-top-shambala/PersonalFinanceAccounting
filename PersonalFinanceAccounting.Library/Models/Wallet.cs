namespace PersonalFinanceAccounting.Library.Models
{
    internal class Wallet : Notify
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string? NameWallet { get; set; }
        public int IdValuta { get; set; }
        public double Amount { get; set; }

    }
}
