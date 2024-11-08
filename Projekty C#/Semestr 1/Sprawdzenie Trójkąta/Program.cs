using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzenie_Trójkąta
{
    internal class Program
        //podajemy 3 kąty trójkąta
        //sprawdzamy czy suma jest równa od 180 
        //wyświetlamy wynik jako valid albo invalid

    {
        static void Main(string[] args)
        {
            const int liczbaKatow = 3;
            int[] katy = new int[liczbaKatow];

            for (int i = 0; i < katy.Length; i++) 
            {
                Console.Write($"Podaj miarę kąta {i+1}: ");
                katy[i] = Convert.ToInt32(Console.ReadLine());
            }

            //bool sumaKatow = 180 == katy[0] + katy[1] + katy[2];
            Console.WriteLine(180 == katy[0] + katy[1] + katy[2] ? "Prawidłowe miary kątów" : "Nieprawidłowe miary kątów");
            Console.Write("Wciśnij enter aby zamknąć okno");
            Console.ReadLine();



        }
    }
}
