using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy_Wstęp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNum = new List<int>();

            listaNum.Add(1);
            listaNum.Add(1);
            listaNum.Add(1);
            listaNum.Add(1);
            
            foreach (int i in listaNum)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj numer który chcesz dodać do listy: ");
                listaNum.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (int i in listaNum)
            {
                Console.Write($"{i} ");
            }
            

            Console.Read();
        }
    }
}
