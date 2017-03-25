using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab03_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Invoice> invoiceList = new List<Invoice>();

            invoiceList.Add(new Invoice(83, "laptop", 7, 57.98));
            invoiceList.Add(new Invoice(24, "ram", 18, 99.99));
            invoiceList.Add(new Invoice(7, "printer", 11, 21.50));
            invoiceList.Add(new Invoice(77, "mouse", 76, 11.99));
            invoiceList.Add(new Invoice(39, "joystick", 3, 79.50));
            invoiceList.Add(new Invoice(68, "bluetooth", 106, 6.99));
            invoiceList.Add(new Invoice(56, "speakers", 21, 11.00));
            invoiceList.Add(new Invoice(3, "keyboard", 34, 7.50));
            foreach (var invoice in invoiceList)
            {
                Console.WriteLine("Part number: {0:3}; Part description: {1:20}; Count: {2:25}; Price per item: {3:30}",
                                   invoice.PartNumber, invoice.PartDescription, invoice.Quantity, invoice.Price);
            }
            Console.WriteLine("Origin array:");

            foreach (var s in invoiceList)
            {
                Console.WriteLine(s);
            }

            var descriptionSorted =
                from s in invoiceList
                orderby s.PartDescription
                select s;

            Console.WriteLine("Description sorted array:");

            foreach (var s in descriptionSorted)
            {
                Console.WriteLine(s);
            }

            var priceSorted =
                from s in invoiceList
                orderby s.Price
                select s;

            Console.WriteLine("Price sorted array:");

            foreach (var s in priceSorted)
            {
                Console.WriteLine(s);
            }

            var sortedlist1 = from s in invoiceList
                              orderby s.Quantity
                              select new { s.PartDescription, s.Quantity };

            Console.WriteLine("\nPart Description and Quantity Only:");
            foreach (var element in sortedlist1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            var sortedlist2 = from s in invoiceList
                              orderby (s.Quantity * s.Price)
                              select new { s.PartDescription, InvoiceTotal = s.Quantity * s.Price };

            Console.WriteLine("\nPart Description and Total Invoice Only:");
            foreach (var element in sortedlist2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            var query5 = from s in sortedlist2
                         where (s.InvoiceTotal >= 200 && s.InvoiceTotal <= 500)
                         select s;

            Console.WriteLine("\n Items which have invoice value in range 200-500:");

            foreach (var element in query5)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}