namespace PersonalFinanceAccounting.Library.Models
{
    internal class User : Notify
    {
        public int Id { get; set; }
        public string? NameUser { get; set; }
        public string? LoginUser { get; set; }
        public string? PasswordUser { get; set; }
        public string? EmailUser { get; set; }
    }
}
