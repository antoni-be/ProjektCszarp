using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieInstrukcjeWarunkowe 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj x: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj y: ");
            var y = Convert.ToInt32(Console.ReadLine());

            var RealAns = x * y;

            Console.Write("Iloczyn " + x + " i " + y + " to: ");
            var ans = Convert.ToInt32(Console.ReadLine());
            while (ans != RealAns)
            {

                Console.WriteLine("Womp womp, zła odpowiedź...");
                Console.WriteLine();
                Console.Write("Spróbujmy jeszcze raz... Iloczyn " + x + " i " + y + " to: ");
                ans = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Dobra odpowiedź!");
            Console.WriteLine();
            Console.Write("Kliknij enter aby zamknąć okno");


            Console.ReadLine();
        }
    }
}
