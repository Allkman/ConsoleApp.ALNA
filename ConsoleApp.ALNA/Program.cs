using System;
using System.Collections.Generic;
using ConsoleApp.ALNA.Service;
namespace ConsoleApp.ALNA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Book library (3 books)
            //result return book

            int userInput = 0;
            var book1 = new BookService();
            book1.SelectBook(userInput);
            
            Console.WriteLine($"Vartotojo pasirinkta knyga: {book1.ReturnBook(userInput)}");

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
