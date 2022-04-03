using System.Xml.Serialization;

namespace Packt.Shared
{
    public class User
    {
        public User()
        {

        }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("creditcard")]
        public string SaltedHashedCreditCard { get; set; }

        public string[] Roles { get; set; }
        public string Salt { get; set; }

        [XmlAttribute("")]
        public string SaltedHashedPassword { get; set; }
    }
}