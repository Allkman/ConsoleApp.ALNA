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
            IBookService bookService = new BookService();



            bookService.SelectBook();
            
            

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
