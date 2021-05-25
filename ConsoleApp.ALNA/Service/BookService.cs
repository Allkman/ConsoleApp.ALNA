using ConsoleApp.ALNA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ALNA.Service
{
    class BookService
    {

        List<Book> bookList = new List<Book>
        {
            new Book()  { BookId = 1, Name= "Laimes Paukstis" },
            new Book()  { BookId = 2, Name= "Paukstis" },
            new Book()  { BookId = 3, Name= "Kamuolys" }
        };
        public Book SelectBook()
        {
            int bookIdInput = 0;
            DisplayBooks();
            while (bookIdInput > bookList.Count || bookIdInput == 0)
            {
                var idInputChar = Console.ReadKey().KeyChar;
                int.TryParse(Console.ReadLine(), out userInput)
                Console.WriteLine("Incorrect book number, try again");
            }
            return userInput - 1;
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
