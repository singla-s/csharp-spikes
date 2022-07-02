using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_training.Features;

namespace csharp_training.Handlers
{
    public class BooksHandler
    {
        public void ExecuteBooksHandler()
        {
            BookList bookList = new BookList();
            bookList.AddBook(new Book("System Design", 99));

            bookList.AddBook(new Book("Data Structure and Algorithm", 199));

            bookList.AddBook(new Book("OOP", 299));

            Console.WriteLine($@"{bookList[2].Title}: ${bookList[2].Price}");
        } 
    }
}
