using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Słowniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> imiona = new Dictionary<int, string>
            {
                {1, "antek"},
                {2, "gosia"},
                {3, "maru"}
            };
            for (int i = 0; i < imiona.Count; i++)
            {
                KeyValuePair<int, string> para = imiona.ElementAt(i);
                Console.WriteLine($"{para.Key} - {para.Value}");

            }
            
            Console.ReadLine();
        }
    }
}
