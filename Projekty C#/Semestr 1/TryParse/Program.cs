using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine()); // Po wpisaniu np. s program zwraca error, funkcja convert.toint32 nie obsługuję innych wartości niż wchodzących do int 
            
            
            Console.Write("Podaj liczbę: ");
            bool proba = int.TryParse(Console.ReadLine(), out int number);

            while(proba == false)
            {
                Console.WriteLine();
                Console.WriteLine("Nieprawidłowa wartość!");
                Console.Write("Podaj poprawną liczbę: ");
                proba = int.TryParse(Console.ReadLine(), out number);
            }
            Console.WriteLine("Twoja liczba to: " + number);

            Console.ReadLine();
        }
    }
}
