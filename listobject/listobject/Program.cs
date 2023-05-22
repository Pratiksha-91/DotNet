using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listobject
{

   
    internal class Program
    {

        public class Book
        {
            public string BookName { get; set; } = string.Empty;

            public string Author { get; set; } = string.Empty;

            public string ISBN { get; set; } = string.Empty;
        }
            static void Main(string[] args)
        {
          


        var bookList = new List<Book>();

        // Intiazize the object and add it to the collection
        var book1 = new Book();
   bookList.Add(book1);

var book2 = new Book();
        bookList.Add(book2);

    }
    }
}
