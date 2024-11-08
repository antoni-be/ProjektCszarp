using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //prosty kalkulator 
            //bez powtarzania linijek kodu
            //w pętli while 

            //podajemy 2 zmienne 
            //zagnieżdżamy w pętli instrukcje warunkową typu case
            //dodaj odejmim pomnóż podziel
            
            Console.Write("Podaj liczbę 1: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj liczbę 2: ");
            double y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Jaką operację chcesz wykonać?");
            string dzialanie = Console.ReadLine();
            while (dzialanie != "zamknij") 
            {
                switch (dzialanie) 
                {
                    case "+":
                        x = x + y;
                        Console.WriteLine($"Wynik to {x}\n\nTwoje liczby to {x} i {y}. ");
                        break;
                    case "-":
                        x = x - y;
                        Console.WriteLine($"Wynik to {x}\n\nTwoje liczby to {x} i {y}. ");
                        break;
                    case "*":
                        x = x * y;
                        Console.WriteLine($"Wynik to {x}\n\nTwoje liczby to {x} i {y}. ");
                        break;
                    case "/":
                        x = x / y;
                        Console.WriteLine($"Wynik to {x}\n\nTwoje liczby to {x} i {y}. ");
                        break;
                    default:
                        Console.WriteLine("Nieobsługiwana operacja");
                        break;
                
                }
                Console.WriteLine("Jaką operację chcesz na nich wykonać?");
                dzialanie = Console.ReadLine();
                    
            }
        }
    }
}
