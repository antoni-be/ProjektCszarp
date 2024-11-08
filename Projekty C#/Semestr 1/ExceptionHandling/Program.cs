using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//comment

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            { 
                try
                { 
                    Console.Write("Podaj numer:");
                    int input = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("numer zapisany pomyslnie");
                    loop =false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"BŁĄD: {e.Message}");
                    Console.WriteLine();
                    Console.WriteLine("Wcisnij ENTER aby spróbować ponownie");
                    Console.ReadLine();
                    Console.Clear();
                }
            
            }
            Console.ReadLine();
        }
    }
}
