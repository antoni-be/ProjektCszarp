using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieMetody2
{
    internal class Program
    {
        /*
            *create and initialise int array of numbers
            *create function SumOfNumbers with int return type
            *int array param
            *function should return total of all numbers 
            *check array length
            *   *return -1 for empty array
            *   *check return in main and return message
         */

        static int[] numery = { 1, 2, 3, 4, 5 };

        static int SumOfArray(int[] arrayka) 
        {
            int Sum = 0;
            foreach (int i in arrayka) {Sum+=i;}
            return Sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfArray(numery));
            Console.ReadLine(); 
        }
    }
}
