using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element);
            }
            Console.WriteLine("\n-----------------------------");

        }
        public static void ToDisplay<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element);

            }
            Console.WriteLine("\n-------------------------------");
        }
        public static void ToExecute<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element);
            }
            Console.WriteLine("\n---------------------------------");

        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.11, 2.34, 54.6, 42.3, 64.8 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            Program.ToPrint<int>(intArray);
            Program.ToDisplay<double>(doubleArray);
            Program.ToExecute<char>(charArray);

        }


    }
}