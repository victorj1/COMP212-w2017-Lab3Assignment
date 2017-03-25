using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab03_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = new List<char>();
            Random rand = new Random();
            char letter = ' ';

            //populate list with random letters (capital letters only)
            Console.WriteLine("------------------------------");
            Console.WriteLine("12 Random Letters");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < 12; i++)
            {
                letter = (char)rand.Next(65, 91);
                letters.Add(letter);
            }

            //control display
            foreach (var element in letters)
                Console.Write(element + " ");

            Console.WriteLine();
            Console.WriteLine("******************************");
            //sort ascending
            Console.WriteLine("Sorted in Ascending Order");
            Console.WriteLine("------------------------------");
            var query = from lt in letters
                        orderby lt ascending
                        select lt;

            foreach (var e in query)
                Console.Write(e + " ");

            Console.WriteLine();
            Console.WriteLine("******************************");
            //sort decending
            Console.WriteLine("Sorted in Decending Order");
            Console.WriteLine("------------------------------");
            var query2 = from lt in letters
                         orderby lt descending
                         select lt;

            foreach (var e in query2)
                Console.Write(e + " ");

            Console.WriteLine();
            Console.WriteLine("******************************");
            //remove duplicates
            Console.WriteLine("Duplicates Removed");
            Console.WriteLine("------------------------------");
            var query3 = (from lt in letters
                          orderby lt ascending
                          select lt).Distinct();

            foreach (var e in query3)
                Console.Write(e + " ");

            Console.ReadLine();
        }
    }
}
