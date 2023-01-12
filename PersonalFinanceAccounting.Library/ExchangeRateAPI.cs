using System.Globalization;
using System.Xml;

namespace PersonalFinanceAccounting.Library
{
    /// <summary>
    /// Класс извлечения курса вавлют из API центрабанка
    /// </summary>
    public static class ExchangeRateAPI
    {
        /// <summary>
        /// Метод получения курса валюты из API центрабанка по ID валюты
        /// </summary>
        /// <param name="ID">ID валюты</param>
        /// <returns>(Decimal) коэфициент курса валюты по отношению к рублю</returns>
        public static decimal ExchangeRate(string ID) //"R01235" USD; "R01239" EUR
        {
            var reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            var ExchangeXml = "";
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Valute")
                {
                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "ID" && reader.Value == ID)
                            {
                                _ = reader.MoveToElement();
                                ExchangeXml = reader.ReadOuterXml();
                            }
                        }
                    }
                }
            }
            var XmlDocument = new XmlDocument();
            XmlDocument.LoadXml(ExchangeXml);
            var xmlNode = XmlDocument.SelectSingleNode("Valute/Value");
            var rate = Convert.ToDecimal(xmlNode.InnerText, new CultureInfo("ru-RU"));
            return rate;
        }
    }
}
