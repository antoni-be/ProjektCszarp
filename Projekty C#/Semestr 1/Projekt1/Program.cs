using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int to liczba całkowita
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //bigNum używany jest kiedy potrzebujemy przypisać zmiennej duże wartości
            long bigNum = 90000000000L;
            Console.WriteLine(bigNum);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            //double używany jest kiedy potrzebujemy przechować tylko dwa miejsca po przecinku
            double negative = -33.5D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //float może przechowywać więcej miejsc po przecinku, używany do przechowywania dokładnych liczb zmiennoprzecinkowych
            float precise = 5.5534F;
            Console.WriteLine(precise);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            //decimal używany tak samo jak double, ale z większa dokładnością (?)
            decimal money = 2.35M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            //int x = 5, y = 10, z = 15;
            //Console.WriteLine(x,);

            //string do przechowywania ciągu znaków
            string name = "antek";
            Console.Write(name);

            //char przechowywany jest do przechowywania tylko i wyłącznie 1 znaku
            char letter = 'b';
            Console.WriteLine(letter);

            //zmiana stringa na int 
            string TextWiek = "35";
            int Wiek = Convert.ToInt32(TextWiek);
            Console.WriteLine(Wiek);

            Console.ReadLine();
        }
    }
}
