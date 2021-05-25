using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ALNA.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public Book(int id, string name)
        {
            BookId = id;
            Name = name;
        }
        public Book()
        {

        }

    }
}
