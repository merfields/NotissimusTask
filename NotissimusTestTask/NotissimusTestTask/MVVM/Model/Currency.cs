using System.Xml.Serialization;

namespace NotissimusTestTask.MVVM.Model
{
    [XmlRoot(ElementName = "currency")]
    public class Currency
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "rate")]
        public string Rate { get; set; }

        [XmlAttribute(AttributeName = "plus")]
        public string Plus { get; set; }
    }

    [XmlRoot(ElementName = "currencies")]
    public class Currencies
    {

        [XmlElement(ElementName = "currency")]
        public Currency Currency { get; set; }
    }

}
