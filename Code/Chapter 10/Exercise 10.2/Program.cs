/*
Create a console application that protects an XML file, such as the following example:

<?xml version=1.0 encoding="utf-8" ?>
    <customers>
        <customer>
            <name>Bob Smith</name>
            <creditcard>1234-5678-9012-3456</creditcard>
            <password>Pa$$w0rd</password>
        </customer>
        ...
    </customers>
</xml>

The customer's credit card number and password are currently stored in clear-text.
The credit card number must be encrypted so that it can be decrypted and used later,
and the password must be salted and hashed.
*/
using Packt.Shared;
using System.Collections.Generic;
using static System.Console;
using static System.Environment;
using System.IO;
using static System.IO.Path;
using System.Xml;

namespace Exercise_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Please enter a password to encrypt the credit card numbers: ");
            string password = ReadLine();

            var customers = new List<User>();
            // Register two customers, note they have the same password
            customers.Add(Protector.Register("Bob Smith", "Pa$$w0rd", "1234-5678-9012-3456"));
            customers.Add(Protector.Register("Alex Rogers", "Pa$$w0rd", "1234-5678-9012-4315"));

            string xmlFile = Path.Combine(CurrentDirectory, "customers.xml");
            var xmlWriter = XmlWriter.Create(xmlFile, new XmlWriterSettings { Indent = true });
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("customers");
            foreach(var customer in customers)
            {
                xmlWriter.WriteStartElement("customer");
                xmlWriter.WriteElementString("name", customer.Name);
                xmlWriter.WriteElementString("creditcard", Protector.Encrypt(customer.CreditCard, password));
                xmlWriter.WriteElementString("password", customer.SaltedHashedPassword);
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            WriteLine();
            WriteLine("Contents of the protected file:");
            WriteLine(File.ReadAllText(xmlFile));
        }
    }
}
