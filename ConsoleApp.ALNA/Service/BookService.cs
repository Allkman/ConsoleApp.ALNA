using ConsoleApp.ALNA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ALNA.Service
{
    class BookService : IBookService
    {
        readonly List<Book> bookList = new List<Book>
        {
            new Book()  { BookId = 1, Name= "The Little Prince" },
            new Book()  { BookId = 2, Name= "The Stand" },
            new Book()  { BookId = 3, Name= "Life of Pi" }
        };
        public Book SelectBook()
        {
            int bookIdInput = 0;
            DisplayBooks();
            Console.WriteLine();
            Console.WriteLine("Input a number that corresponds to a book");
            while (bookIdInput > bookList.Count || bookIdInput == 0)
            {
                var idChar = Console.ReadKey().KeyChar;
                int.TryParse(idChar.ToString(), out bookIdInput);
                if (bookIdInput > bookList.Count || bookIdInput == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"input of {idChar} is not correct. Please try again.");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You have selected: {bookList[bookIdInput-1].Name}");
            return bookList[bookIdInput-1];
        }
        public void DisplayBooks()
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine("{0} .. {1}", i+1, bookList[i].Name);
            }
        }
    }
}
