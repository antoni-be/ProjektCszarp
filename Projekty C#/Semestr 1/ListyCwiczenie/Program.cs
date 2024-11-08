using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyCwiczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();    
            List<int> even = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                { 
                    odd.Add(i); 
                }
            }

            foreach (int i in odd)
            {
                Console.Write($"{i} ");

            }

            Console.WriteLine();

            foreach (int i in even)
            {
                Console.Write($"{i} ");

            }

            Console.Read();
        }
    }
}
