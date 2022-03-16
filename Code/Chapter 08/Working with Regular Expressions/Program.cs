using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Working_with_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: ");
            string input = ReadLine();
            var ageChecker = new Regex(@"^\d+$");
            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
            }

            string films = "\"Monsters Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
            string[] filmsDumb = films.Split(',');
            WriteLine("Dumb attempt at splitting:");
            foreach(string film in filmsDumb)
            {
                WriteLine(film);
            }

            var csv = new Regex(
                "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)"
            );
            MatchCollection filmsStart = csv.Matches(films);
            WriteLine("Smart attempt at splitting:");
            foreach(Match film in filmsStart)
            {
                WriteLine(film.Groups[2].Value);
            }
        }
    }
}
