using System.Xml;

namespace PersonalFinanceAccounting.Library
{
    public static class ExchangeRateAPI
    {
        public static decimal ExchangeRate(string ID) //"R01235" USD; "R01239" EUR
        {
            var reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            var ExchangeXml = "";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:

                        if (reader.Name == "Valute")
                        {
                            if (reader.HasAttributes)
                            {
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == "ID")
                                    {
                                        if (reader.Value == ID)
                                        {
                                            reader.MoveToElement();
                                            ExchangeXml = reader.ReadOuterXml();
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
            }
            XmlDocument XmlDocument = new XmlDocument();
            XmlDocument.LoadXml(ExchangeXml);
            XmlNode xmlNode = XmlDocument.SelectSingleNode("Valute/Value");
            decimal rate = Convert.ToDecimal(xmlNode.InnerText);
            return rate;
        }
    }
}
