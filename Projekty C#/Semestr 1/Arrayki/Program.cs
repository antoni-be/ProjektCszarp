using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrayki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] inputy = new int[5];
            for (int i = 0; i < inputy.Length; i++)
            {
                Console.Write($"{i + 1}. Podaj liczbę którą chcesz zapisać:");
                inputy[i] = Convert.ToInt32(Console.ReadLine());
            
            }            
            Console.WriteLine();
            Console.Write("Twoje liczby to: " );
            for (int i = 0; i < inputy.Length; i++)
            {
                Console.Write($", {inputy[i]}"); 
            }
            */

            string[] slowa = new string[4];
            
            Console.Write("Podaj słowo, które chcesz zapisać: ");
            slowa[0] = Console.ReadLine();

            for (int i = 1; i < slowa.Length; i++) 
            {
                Thread.Sleep(200);
                Console.Write($"Słowo \"{slowa[i - 1]}\" zostało zapisane pomyślnie, podaj kolejne słowo: ");
                slowa[i] = Console.ReadLine();
            }
            
            Console.WriteLine($"Słowa które zapisałeś to:");
            for (int i = 0;i < slowa.Length; i++)  
            {
                Console.WriteLine($"- {slowa[i]}");
            }

            Console.Write("Wciśnij enter aby zamknąć okno");
            Console.ReadLine();
        }
    }
}
