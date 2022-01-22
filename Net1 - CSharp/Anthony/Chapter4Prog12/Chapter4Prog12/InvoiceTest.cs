using System;


namespace Chapter4Prog12
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            //create some Invoice objects
            Invoice inv1 = new Invoice();
            /*Console.WriteLine("part number = " + inv1.PartNumber);
            Console.WriteLine("part description = " + inv1.PartDescription);
            Console.WriteLine("quantity = " + inv1.Quantity);
            Console.WriteLine("price per item = " + inv1.PricePerItem);*/

            inv1.PartNumber = "0001234";
            inv1.PartDescription = "Yellow Hammer";
            inv1.Quantity = 3;
            inv1.PricePerItem = 19.49M;

            Console.WriteLine("Invoice total is {0:C}", inv1.GetInvoiceAmount());

            Invoice inv2 = new Invoice("0001111", "Paint Brush", 10, 17.99m);

            Console.WriteLine("Invoice total is {0:C}", inv2.GetInvoiceAmount());
            inv2.PricePerItem = -12m;

            Console.WriteLine("Invoice total is {0:C}", inv2.GetInvoiceAmount());
            //Console.WriteLine(inv2.ToString());

        }
    }
}
