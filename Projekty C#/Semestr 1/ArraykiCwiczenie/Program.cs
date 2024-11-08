using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraykiCwiczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Podaj liczbę której wielokrotności chcesz wyświetlić: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ile wielokrotności liczby {num} chcesz wyświetlić? ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            */

            int num = 4;
            int length = 7;

            int[] wielokrotnosci = new int[length];
            for (int i = 0; i < wielokrotnosci.Length; i++)
            {
                wielokrotnosci[i] = num * (i+1);
            }

            for (int i = 0; i < wielokrotnosci.Length; i++)
            {
                Console.WriteLine($"{num} * {i+1} = {wielokrotnosci[i]}");            
            }




            Console.Read();
        }
    }
}
