using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Print_po_znaku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slowo = Console.ReadLine();
            for (int i = 0; i < slowo.Length; i++)
            {
                Console.Write(slowo[i]);
                Thread.Sleep(100);
            }
            Console.Read();
        }
    }
}
