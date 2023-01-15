namespace PersonalFinanceAccounting.Library.Models;

/// <summary>
/// Класс Валюта
/// </summary>
public class Valuta
{
    /// <summary>
    ///  Id - идентификатор валюты
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name - название валюты
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///  Code - код валюты
    /// </summary>
    public int Code { get; set; }
}
