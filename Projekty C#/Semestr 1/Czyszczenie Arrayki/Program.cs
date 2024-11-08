using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czyszczenie_Arrayki
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

            //jeśli chcemy zacząć od indexu innego niż 0 musimy tez skrócić długość wykonywania funkcji
            Array.Clear(numery, 3, numery.Length - 3); 
            foreach (int numer in numery)
            {
                Console.Write(numer);
            }




            Console.ReadLine();
        }
    }
}
