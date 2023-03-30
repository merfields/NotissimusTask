using System;
using System.Xml.Serialization;

namespace NotissimusTestTask.MVVM.Model
{
    [XmlRoot(ElementName = "yml_catalog")]
    public class YmlCatalog
    {

        [XmlElement(ElementName = "shop")]
        public Shop Shop { get; set; }

        [XmlAttribute(AttributeName = "date")]
        public String Date { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}
