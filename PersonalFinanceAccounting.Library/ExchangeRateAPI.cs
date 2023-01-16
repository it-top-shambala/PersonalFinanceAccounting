using System.Globalization;
using System.Xml;

namespace PersonalFinanceAccounting.Library;

/// <summary>
/// Класс извлечения курса вавлют из API ЦБ РФ
/// </summary>
public static class ExchangeRateApi
{
    /// <summary>
    /// Метод получения курса валюты из API ЦБ РФ по ID валюты
    /// </summary>
    /// <param name="id">ID валюты</param>
    /// <returns>(Decimal) коэфициент курса валюты по отношению к рублю</returns>
    /// <remark> перед использовавнием метода ExchangeRate() нужно вызвать метод Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);</remark>
    public static decimal ExchangeRate(string id) //"R01235" USD; "R01239" EUR
    {
        var reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
        var exchangeXml = "";
        while (reader.Read())
        {
            if (reader.NodeType != XmlNodeType.Element || reader is not { Name: "Valute", HasAttributes: true })
            {
                continue;
            }

            while (reader.MoveToNextAttribute())
            {
                if (reader.Name != "ID" || reader.Value != id)
                {
                    continue;
                }

                _ = reader.MoveToElement();
                exchangeXml = reader.ReadOuterXml();
            }
        }

        var xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(exchangeXml);
        var xmlNode = xmlDocument.SelectSingleNode("Valute/Value");
        var rate = Convert.ToDecimal(xmlNode.InnerText, new CultureInfo("ru-RU"));
        return rate;
    }
}
