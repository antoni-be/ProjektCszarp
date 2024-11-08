using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieModuł
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=12; int y=3;
            var reminder = x % y;
            Console.WriteLine(reminder);
            y=2; reminder = x % y;
            Console.WriteLine(reminder);

            Console.Write("Jak masz na imię: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Cześć " + imie + "!");

            Console.ReadLine();
        }
    }
}
