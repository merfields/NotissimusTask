using System.Collections.Generic;
using System.Xml.Serialization;

namespace NotissimusTestTask.MVVM.Model
{
    [XmlRoot(ElementName = "category")]
    public class Category
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "parentId")]
        public string ParentId { get; set; }
    }

    [XmlRoot(ElementName = "categories")]
    public class Categories
    {

        [XmlElement(ElementName = "category")]
        public List<Category> Category { get; set; }
    }

    [XmlRoot(ElementName = "categoryId")]
    public class CategoryId
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}
