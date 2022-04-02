/*
Create a console application that protects and XML file, such as the following example:

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

using System;
using System.Collections.Generic;
using static System.Console;

namespace Exercise_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
