using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Threading;  

namespace Print_od_tylu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slowo = "stara laury";
            Console.WriteLine(slowo);
            Console.WriteLine(slowo.Length);

            Console.Write($"{slowo} od tylu to: ");
            for (int i = slowo.Length - 1; i >=0; --i)
            {
                Console.Write(slowo[i]);
                Thread.Sleep(150);
            }
            
            Console.Read();
        }
    }
}
