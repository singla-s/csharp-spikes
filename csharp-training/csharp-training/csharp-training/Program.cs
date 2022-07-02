using csharp_training.Handlers;

namespace CSharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BooksHandler booksHandler = new BooksHandler();
            booksHandler.ExecuteBooksHandler();
        }
    }
}
