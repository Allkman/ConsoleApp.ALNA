using System;
using System.Collections.Generic;
using ConsoleApp.ALNA.Service;
namespace ConsoleApp.ALNA
{
    class Program
    {
        //Book library (3 books)
        //result return book
        static void Main(string[] args)
        {
            Console.WriteLine("Select one of the books bellow:");
            Console.WriteLine();

            IBookService bookService = new BookService();
            bookService.SelectBook();         
            
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
