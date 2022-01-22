//Anthony Fuller Chapter 9 Program 3

using System;
using System.Linq;

namespace AF_Ch9
{
    class Program
    {
        static void Main(string[] args)
        {
            //create some Invoice objects
            Invoice[] invoices = {
                new Invoice(83,"Electric sander",7,57.98M),
                new Invoice(24,"Power saw",18,99.99M),
                new Invoice(7,"Sledge hammer",11,21.50M),
                new Invoice(77,"Hammer",76,11.99M),
                new Invoice(39,"Lawn mower",3,79.50M),
                new Invoice(68,"Screwdriver",106,6.99M),
                new Invoice(56,"Jig saw",21,11.00M),
                new Invoice(3,"Wrench",34,7.50M) };

            Console.WriteLine("Original array:");
            foreach (var element in invoices)
                Console.WriteLine(element);

            var partDescSorted =
                from e in invoices
                orderby e.PartDescription
                select e;

            Console.WriteLine("\n Array sorted by PartDescription:");
            foreach (var element in partDescSorted)
                Console.WriteLine(element);

            var priceSorted =
                from e in invoices
                orderby e.Price
                select e;

            Console.WriteLine("\n Array sorted by Price:");
            foreach (var element in priceSorted)
                Console.WriteLine(element);

            var amount =
                from e in invoices
                orderby e.Quantity
                select new {e.PartDescription, Quantity = e.Quantity};

            Console.WriteLine("\n PartDescription and Quantity sorted by Quantity:");
            foreach (var element in amount)
                Console.WriteLine(element);

            var InvoiceTotal =
                from e in invoices
                let totalPrice = e.Quantity * e.Price
                orderby totalPrice
                select new {e.PartDescription, totalPrice};

            Console.WriteLine("\n Quantity * Price:");
            foreach (var element in InvoiceTotal)
                Console.WriteLine(element);

            var between200500 =
                from e in InvoiceTotal
                where e.totalPrice >= 200M && e.totalPrice <= 500M
                select e;

            Console.WriteLine( string.Format(
                "\n Parts in between the range {0:C}-{1:C}:",200,500));
            foreach (var element in between200500)
                Console.WriteLine(element);
        }
    }
}
