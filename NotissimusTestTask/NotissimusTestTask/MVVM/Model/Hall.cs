using System.Xml.Serialization;

namespace NotissimusTestTask.MVVM.Model
{
    [XmlRoot(ElementName = "hall")]
    public class Hall
    {

        [XmlAttribute(AttributeName = "plan")]
        public string Plan { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}
