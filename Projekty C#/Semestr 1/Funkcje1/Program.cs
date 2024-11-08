using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Przywitanie("pało");
            Console.ReadLine();
        }

        static void Przywitanie(string imie) 
        { 
            Console.WriteLine($"Hej {imie}");
            
        }

    }
}
