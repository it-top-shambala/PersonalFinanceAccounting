namespace PersonalFinanceAccounting.Library.Models
{
    internal class Valuta : Notify
    {
        public int Id { get; set; }
        public string? NameValuta { get; set; }
        public int CodeValuta { get; set; }
    }
}
