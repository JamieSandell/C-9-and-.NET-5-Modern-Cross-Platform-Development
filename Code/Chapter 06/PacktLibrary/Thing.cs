// Highlights the need for Generics introduced in C# 2.
using System;

namespace Packt.Shared
{
    public class Thing
    {
        public object Data = default(object);
        public string Process(object input) // Flexible, but no type checking, unexpected results when passing in an int
        {
            if (Data == input)
            {
                return "Data and input are the same.";
            }
            else
            {
                return "Data and input are NOT the same.";
            }
        }
    }
}