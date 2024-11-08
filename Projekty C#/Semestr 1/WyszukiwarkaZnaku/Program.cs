using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyszukiwarkaZnaku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wklej tekst który chcesz przeszukać: ");
            string text = Console.ReadLine();

            Console.Write("Podaj znak który chcesz sprawdzić czy występuje w tekście: ");
            char check = Convert.ToChar(Console.ReadLine());

            bool exists = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(check)) 
                {  
                    exists = true; 
                    break; 
                }
            }

            Console.WriteLine();
            Console.WriteLine(exists ? $"Znak \"{check}\" występuje w tekście" : $"Znak \"{check}\" nie występuje w tekście");
            
            Console.Read();
        }
    }
}
