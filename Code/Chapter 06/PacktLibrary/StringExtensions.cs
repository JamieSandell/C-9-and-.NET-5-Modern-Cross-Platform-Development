using System.Text.RegularExpressions;

namespace Packt.Shared
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            // use simple regular expression to check
            return Regex.IsMatch(input, @"[a-zA-Z0-9.\-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}