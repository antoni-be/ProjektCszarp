using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpsze input: ");
            string input = Console.ReadLine();

            while (input.Equals(String.Empty))
            {
                Console.Write("Nie wykryłem inputu, spróbuj jeszcze raz:");
                input = Console.ReadLine();
                Console.WriteLine();
            }          

            Console.WriteLine($"Napisałeś: {input}");
            Console.Read();
        }
    }
}
