namespace PersonalFinanceAccounting.Library.Models;

/// <summary>
/// Класс Кошелек
/// </summary>
public class Wallet
{
    /// <summary>
    ///  Id - идентификатор кошелька
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///  Name - название кошелька
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// IdValuta - идентификатор валюты
    /// </summary>
    public int IdValuta { get; set; }

    /// <summary>
    /// Amount - количество средств в кошельке
    /// </summary>
    public float Amount { get; set; }

    /// <summary>
    /// Метод пополнения кошелька
    /// </summary>
    /// <param name="sum">sum - сумма пополнения</param>
    public void Put(float sum)
    {
        Amount += sum;
    }

    /// <summary>
    /// Метод получения из кошелька
    /// </summary>
    /// <param name="sum">sum - сумма получения</param>
    public void Take(float sum)
    {
        if (Amount >= sum)
        {
            Amount -= sum;
        }
    }
}
