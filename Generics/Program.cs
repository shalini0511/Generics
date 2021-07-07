using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        public static void ToPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------");

        }
        public static void ToPrint(double[] inputArray)
        {
            foreach(double element in inputArray)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine("-------------------------------");
        }
        public static void ToPrint(char[] inputArray)
        {
            foreach(char element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------------");
 
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.11,2.34,54.6,42.3,64.8 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            Program.ToPrint(intArray);
            Program.ToPrint(doubleArray);
            Program.ToPrint(charArray);

        }
    }
}
