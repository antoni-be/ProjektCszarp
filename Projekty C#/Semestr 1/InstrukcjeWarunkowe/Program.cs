using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj swój wiek aby wziąć udział: ");
            var wiek=Convert.ToInt32(Console.ReadLine());
            /*if(wiek >= 18 && wiek <= 23)
            {
                Console.WriteLine("Twój wiek mieści się w przedziale 18 do 23.");
            }

            else
            {
                Console.WriteLine("Niestety nie kwalifikujesz się do przedziału wiekowego");
            }
            */
            if (wiek < 0 || wiek > 150)
            {
                Console.WriteLine("Nieprawidłowy wiek");
            }
            else 
            {
                
                if (wiek >= 18 && wiek <= 23)
                {
                    Console.WriteLine("Twój wiek mieści się w przedziale 18 do 23.");
                }

                else
                {
                    Console.WriteLine("Niestety nie kwalifikujesz się do przedziału wiekowego");
                }
            }
                Console.ReadLine();
        }
    }
}
