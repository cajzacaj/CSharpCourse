using System;

namespace ClassesBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book();
            b1.Isbn = "978-1-52-660620-4";
            b1.Author = "JK Rowling";
            b1.NrOfPages = 356;
            b1.ProductID = 394;

            var eb1 = new ElectronicBook();

            eb1.Isbn = "978-3-16-148410-0";
            eb1.Author = "J R R Tolkien";
            eb1.NrOfPages = 400;
            eb1.ProductID = 237;


            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {b1.Isbn}");
            Console.WriteLine($"   Författare:  {b1.Author}");
            Console.WriteLine($"   Antal sidor: {b1.NrOfPages}");
            Console.WriteLine($"   Vikt:        {b1.WeightInGrams} gram");
            Console.WriteLine($"   Storlek:     {b1.Size}");
            Console.WriteLine($"   ProductID:   {b1.ProductID}");
            Console.WriteLine();
            Console.WriteLine($"Info om E-boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {eb1.Isbn}");
            Console.WriteLine($"   Författare:  {eb1.Author}");
            Console.WriteLine($"   Antal sidor: {eb1.NrOfPages}");
            Console.WriteLine($"   Vikt:        {eb1.WeightInGrams} gram");
            Console.WriteLine($"   Storlek:     {eb1.Size}");
            Console.WriteLine($"   ProductID:   {eb1.ProductID}");
            Console.WriteLine();
            Console.WriteLine($"Anrop");
            Console.WriteLine();
            eb1.SendBookTo("cajzacaj@gmail.com");

            bool isProduct = b1 is Product;
            bool isBook = b1 is Book;
            bool isEBook = b1 is ElectronicBook;

            Console.WriteLine();
            Console.WriteLine($"Olika test:");
            Console.WriteLine();
            Console.WriteLine($"   Är b1 en product?     {isProduct}");
            Console.WriteLine($"   Är b1 en bok?         {isBook}");
            Console.WriteLine($"   Är b1 en e-bok?       {isEBook}");
            Console.WriteLine(
                );

            isProduct = eb1 is Product;
            isBook = eb1 is Book;
            isEBook = eb1 is ElectronicBook;

            Console.WriteLine($"   Är eb1 en product?    {isProduct}");
            Console.WriteLine($"   Är eb1 en bok?        {isBook}");
            Console.WriteLine($"   Är eb1 en e-bok?      {isEBook}");
        }
    }
}
