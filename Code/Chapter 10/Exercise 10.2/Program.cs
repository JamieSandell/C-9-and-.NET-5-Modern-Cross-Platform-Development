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
using System;
using System.Collections.Generic;
using static System.Console;
using static System.Environment;
using System.IO;
using System.Xml.Serialization;

namespace Exercise_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<User>();
            customers.Add(Protector.Register("Bob Smith", "Pa$$w0rd", "1234-5678-9012-3456"));
            var xs = new XmlSerializer(typeof(List<User>));
            string path = Path.Combine(CurrentDirectory, "customers.xml");
            using (FileStream fileStream = File.Create(path))
            {
                xs.Serialize(fileStream, customers);
            }
            WriteLine("Written {0:N0} bytes of XML to {1}",
                arg0: new FileInfo(path).Length,
                arg1: path);
            WriteLine();
            WriteLine(File.ReadAllText(path));
        }
    }
}
