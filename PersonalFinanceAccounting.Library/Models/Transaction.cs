namespace PersonalFinanceAccounting.Library.Models
{
    public static class Transaction
    {
        // добавление средств в кошелек
        public static float Put(float amount, float sum)
        {
            return amount += sum;
        }
        // списание средств из кошелька
        public static float Take(float amount, float sum)
        {
            if (amount >= sum)
            {
                amount -= sum;
            }
            return amount;
        }
}
}
