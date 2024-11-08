using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Program

    {
        static void Main(string[] args)
        {
            double money = 10D / 3D;
            Console.WriteLine(money);
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", 
                CultureInfo.CreateSpecificCulture("en-US")));

            Console.ReadLine();
        }
    }
}
