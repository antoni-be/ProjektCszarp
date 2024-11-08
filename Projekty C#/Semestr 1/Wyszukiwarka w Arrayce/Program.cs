using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyszukiwarka_w_Arrayce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numery = new int[]
            {
                1,6,3,2,5
            };

            foreach (int numer in numery)
            {
                Console.Write($"{numer} ");
            }

            Console.WriteLine();

            Console.Write("Wpisz numer który chcesz wyszukać: ");
            int zapytanie = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numery, zapytanie);

            if (position > -1)
            {
                Console.WriteLine($"Numer {zapytanie} znajduje się na pozycji {position + 1}");
            }
            else
            {
                Console.WriteLine($"Numer {zapytanie} nie znajduje się w zbiorze liczb :(");
            }



            Console.ReadLine();
        }
    }
}
