using System;
using static System.Console;

namespace Exercise_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What is the maximum number of characters that can be stored in a string variable?");
            WriteLine("2^30 since a 2 GB limit is imposed by the .NET CLR.");
            WriteLine();
            WriteLine("2.) When and why should you use a SecureString class?");
            WriteLine("Represents text that should be kept confidential, such as by deleting it from computer memory when no longer needed. The class cannot be inherited.");
            WriteLine();
            WriteLine("3.) When is it appropriate to use a StringBuilder type?");
            WriteLine("If you're in a hot path or a loop and you're concatenating strings, as that returns a new string object if you use string as opposed to StringBuilder.");
            WriteLine();
            WriteLine("4.) When should you use a LinkedList<T> class?");
            WriteLine("Represents a doubly linked list where every item has a reference to its previous and next items. They provide better performance compared to List<T> for scenarios where you will frequently insert and remove items from the middle of the list because in a LinkedList<T> the items do not have to be rearranged in memory.");
            WriteLine();
            WriteLine("5.) When should you use a SortedDictionary<T> class rather than a SortedList<T> class?");
            WriteLine("Both have O(log n) retrieval. The two classes differ in memory use and speed of insertion and removal.");
            WriteLine("SortedDictionary<T> uses less memory and has faster insertion and removal operations for unsorted datam O(log n) as opposed to O(n).");
            WriteLine("If the list is populated all at once from sorted data, SortedDictionary<T> is slower than SortedList<T>");
            WriteLine();
            WriteLine("6.) What is the ISO culture code for Welsh?");
            WriteLine("cy-GB");
            WriteLine();
            WriteLine("7.) What is the difference between localization, globalization and internationalization?");
            WriteLine("Localization is the process of customisation to make the application behave as per the current culture and locale.");
            WriteLine("Globalization is the process of designing the application in such a way that it can be used by users from across the globe (multiple cultures).");
            WriteLine("Internationalization is the process of developing applications which can be made available in multiple locations supporting different languages and cultures.");
            WriteLine();
            WriteLine("8.) In a regular express what does $ mean?");
            WriteLine("End of string or end of line");
            WriteLine();
            WriteLine("9.) In a regular expressio, how could you represent digits?");
            WriteLine("\\d matches any single digit, \\d+ matches one or more digits.");
            WriteLine();
            WriteLine("10.) Why should you not use the official standard for email addresses to create a regular expression to validate a user's email address?");
            WriteLine("No idea what is being asked, but there doesn't seem to be a consensus of a good way: https://www.wired.com/2008/08/four-regular-expressions-to-check-email-addresses/");
            WriteLine();
        }
    }
}
