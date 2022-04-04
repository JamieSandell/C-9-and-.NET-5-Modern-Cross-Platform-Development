/*
Create a console application that opens the XML file that you protected
in the preceeding code and decrypts the credit card number.
*/

using Packt.Shared;
using System.Collections.Generic;
using static System.Console;
using static System.Environment;
using System.IO;
using static System.IO.Path;
using System.Security.Cryptography;
using System.Xml;

namespace Exercise_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the credit card decryption password: ");
            string password = ReadLine();
            var customers = new List<User>();

            string xmlFile = Combine(CurrentDirectory, "customers.xml");
            if (!File.Exists(xmlFile))
            {
                WriteLine($"{xmlFile} does not exist");
                return;
            }

            var xmlReader = XmlReader.Create(xmlFile, new XmlReaderSettings { IgnoreWhitespace = true });
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "customer")
                {
                    xmlReader.Read(); // inside the customer node, so move to the name
                    string name = xmlReader.ReadElementContentAsString();
                    string creditCardEncrypted = xmlReader.ReadElementContentAsString();
                    string creditCard = null;
                    string errorMessage = null;
                    try
                    {
                        creditCard = Protector.Decrypt(creditCardEncrypted, password);
                    }
                    catch (CryptographicException ex)
                    {
                        errorMessage = $"Decrypting the credit card failed with {ex.Message}";
                    }
                    string passwordHashed = xmlReader.ReadElementContentAsString();
                    string salt = xmlReader.ReadElementContentAsString();

                    customers.Add(new User
                    {
                        Name = name,
                        CreditCard = creditCard ?? errorMessage,
                        SaltedHashedPassword = passwordHashed,
                        Salt = salt
                    });
                }
            }
            xmlReader.Close();

            WriteLine();
            int number = 0;
            WriteLine("     {0, -20} {1, -20}",
                arg0: "Name",
                arg1: "Credit Card");

            foreach (var customer in customers)
            {
                WriteLine("[{0}] {1, -20} {2, -20}",
                    arg0: number,
                    arg1: customer.Name,
                    arg2: customer.CreditCard);
                ++number;
            }
            WriteLine();

            Write("Press the number of a customer to log in as: ");
            string customerName = null;
            try
            {
                number = int.Parse(ReadKey().KeyChar.ToString());
                customerName = customers[number].Name;
            }
            catch
            {
                WriteLine();
                WriteLine("Not a valid customer selection");
                return;
            }

            WriteLine();
            Write($"Enter {customerName}'s password: ");
            string attemptedPassword = ReadLine();
            if (Protector.CheckPassword(
                password: attemptedPassword,
                salt: customers[number].Salt,
                hashedPassword: customers[number].SaltedHashedPassword))
            {
                WriteLine("Correct!");
            }
            else
            {
                WriteLine("Wrong!");
            }
        }
    }
}
