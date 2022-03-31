using System.Xml.Serialization;

namespace Exercise_9._2
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    abstract public class Shape
    {
        public abstract double Area { get; }

        public string Color { get; set; }
    }
}