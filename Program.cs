﻿namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator Program");
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoice.CalculateFare(2.0, 5);
            Console.WriteLine(fare);
        }
    }
    }

