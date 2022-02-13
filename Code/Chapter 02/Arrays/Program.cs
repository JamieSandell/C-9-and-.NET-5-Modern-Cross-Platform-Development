using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names; // can reference an array of strings
            names = new string[4]; // allocating memory for four strings in an array
            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            // loop through
            for (int i = 0; i < names.Length; ++i)
            {
                // output the item at position i
                Console.WriteLine(names[i]);
            }
        }
    }
}
