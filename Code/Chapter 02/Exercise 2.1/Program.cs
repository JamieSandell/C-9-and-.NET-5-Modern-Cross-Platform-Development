using System;
using static System.Console;

namespace Exercise_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "{0, -140} {1, -8}";
            WriteLine("What type would you choose for the following \"numbers\"?");
            //Write("1. A person's telephone number: ");
            WriteLine(
                format: format,
                arg0: "1. A person's telephone number: ",
                arg1: "string");
            WriteLine(
                format: format,
                arg0: "2. A person's height: ",
                arg1: "float");
            WriteLine(
            format: format,
            arg0: "3. A person's age: ",
            arg1: "int");
            WriteLine(
            format: format,
            arg0: "4. A person's salary: ",
            arg1: "decimal");
            WriteLine(
            format: format,
            arg0: "5. A book's ISBN: ",
            arg1: "string");
            WriteLine(
            format: format,
            arg0: "6. A book's price: ",
            arg1: "decimal");
            WriteLine(
            format: format,
            arg0: "7. A book's shipping weight: ",
            arg1: "float");
            WriteLine(
            format: format,
            arg0: "8. A country's population: ",
            arg1: "int");
            WriteLine(
            format: format,
            arg0: "9. The number of stars in the universe: ",
            arg1: "double");
            WriteLine(
            format: format,
            arg0: "10. The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): ",
            arg1: "int");
        }
    }
}
