using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieMetody1
{
    internal class Program
    {
        //Zapytaj o szerokość i wysokość, zapisz
        //stwórz funkcję obliczającą pole 
        //wywołać funkcję i podać pole trójkąta
        static int ReadInt(string wiadomosc)
        { 
            Console.Write(wiadomosc);
            return  Convert.ToInt32(Console.ReadLine());
        }

        static double ObliczPole(int wysokoscF, int dlugoscF)
        {
            return ((wysokoscF * dlugoscF) / 2);
        }

        static void Main(string[] args)
        {
            int wysokosc = ReadInt("Podaj wysokość: ");
            int dlugosc = ReadInt("Podaj długość boku: ");
            Console.WriteLine($"Pole takiego trójkąta to: {ObliczPole(wysokosc,dlugosc)}");
            Console.ReadLine();
        }
    }
}
