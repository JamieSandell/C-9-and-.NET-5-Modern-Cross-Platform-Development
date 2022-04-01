using System;
using static System.Console;

namespace Exericse_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) Of the encryption algorithms provided by .NET, which is the best choice for symmetric encryption?");
            WriteLine("AES");
            WriteLine();
            WriteLine("2.) Of the encryption algorithms provided by .NET, which is the best choice for asymmetric encryption?");
            WriteLine("RSA");
            WriteLine();
            WriteLine("3.) What is a rainbow attack?");
            WriteLine("A password cracking method that uses a special table (a \"rainbow table\") to crack the password hashes in a database.");
            WriteLine();
            WriteLine("4.) For encryption algorithms, is it better to have a larger or smaller block size?");
            WriteLine("Block size does matter for security, but only up to the point where there is no possible attack with plausible technology.");
            WriteLine();
            WriteLine("5.) What is a hash?");
            WriteLine("Hashing on an input text provides a hash value.");
            WriteLine();
            WriteLine("6.) What is a signature?");
            WriteLine("A cryptographic value that is calculated from the data and a secret key known only by the signer.");
            WriteLine();
            WriteLine("7.) What is the difference between symmetric and asymmetric encryption?");
            WriteLine("Symmetric encryption uses a key (secret) to both encrypt and decrypt electronic information.");
            WriteLine("Asymmetric encryption encrypts and decrypts the data using two separate yet mathematically connected cryptographic keys (Public Key and Private Key).");
            WriteLine();
            WriteLine("8.) What does RSA stand for?");
            WriteLine("Rivest-Shamir-Adleman encryption.");
            WriteLine();
            WriteLine("9.) Why should passwords be salted before being stored?");
            WriteLine("To make sure two password hashes, even if they're the same password, are unique");
            WriteLine();
            WriteLine("10.) SHA1 is a hashing algorithm designed by the United States National Security Agency. Why should you never use it?");
            WriteLine("Digital fingerprints generated with it can be forged and cannot be trusted.");
        }
    }
}
