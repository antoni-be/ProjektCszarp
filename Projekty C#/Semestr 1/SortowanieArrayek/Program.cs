using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieArrayek
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
            
            Array.Sort(numery);
            foreach (int numer in numery)
            {
                Console.Write(numer);
            }


           
            Console.ReadLine();
        }
    }
}
