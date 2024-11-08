using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzanie_hasła
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj hasło: ");
            string haslo1 = Console.ReadLine();

            Console.Write("Podaj hasło: ");
            string haslo2 = Console.ReadLine();
            if (!string.IsNullOrEmpty(haslo1) && !string.IsNullOrEmpty(haslo2))
            {
                if (haslo1 == haslo2)
                {
                    Console.WriteLine("Poprawne hasło");
                }
                else
                {
                    Console.WriteLine("Hasła są od siebie różne");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowe hasło, podaj hasło:");
            }
            Console.Read();

        }
    }
}
