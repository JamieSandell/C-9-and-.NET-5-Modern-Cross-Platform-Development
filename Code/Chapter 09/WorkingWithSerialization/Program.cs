using Packt.Shared;
using System;
using System.Collections.Generic;
using static System.Console;
using static System.Environment;
using System.IO;
using static System.IO.Path;
using System.Xml.Serialization;

namespace WorkingWithSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person(30000M)
                {
                    FirstName = "Alice",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1974, 3, 14)
                },
                new Person(40000M)
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth
                }
            }
        }
    }
}
