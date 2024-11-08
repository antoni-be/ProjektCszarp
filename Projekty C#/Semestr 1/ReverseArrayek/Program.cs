using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayek
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
                Console.Write(numer);
            }

            Console.WriteLine();

            Array.Reverse(numery);
            foreach (int numer in numery)
            {
                Console.Write(numer);
            }



            Console.ReadLine();
        }
    }
}
