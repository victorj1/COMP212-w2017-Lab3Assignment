using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab03_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] intArray = { 1, 2, 3, 4, 5, 6 };
                double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
                char[] charArray = { 'A', 'B', 'V', 'X', 'Z' };

                Console.Write("Array intArray contains:     ");
                DisplayArray(intArray, 1, 5);
                Console.Write("Array doubleArray contains:  ");
                DisplayArray(doubleArray, 2, 7);
                Console.Write("Array charArray contains:    ");
                DisplayArray(charArray, 0, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void DisplayArray(int[] inputArray, int lowIndex, int highIndex)
        {
            if (lowIndex >= 0 && highIndex <= inputArray.Length && highIndex > lowIndex)
            {
                for (int i = lowIndex; i < highIndex; i++)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Low index and high index values incorrect");
            }
            Console.WriteLine();
        }


        private static void DisplayArray(double[] inputArray, int lowIndex, int highIndex)
        {
            if (lowIndex >= 0 && highIndex <= inputArray.Length && highIndex > lowIndex)
            {
                for (int i = lowIndex; i < highIndex; i++)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Low index and high index values incorrect");
            }
            Console.WriteLine();
        }


        private static void DisplayArray(char[] inputArray, int lowIndex, int highIndex)
        {
            if (lowIndex <= 0 && highIndex <= inputArray.Length && highIndex > lowIndex)
            {
                for (int i = lowIndex; i < highIndex; i++)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Low index and high index values incorrect");
            }
            Console.WriteLine();
        }
    }
}