using csharp_training.Services;

namespace CSharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BookList bookList = new BookList();
            bookList.AddBook(new Book("System Design", 99));

            bookList.AddBook(new Book("Data Structure and Algorithm", 199));

            bookList.AddBook(new Book("OOP", 299));

            Console.WriteLine($@"{bookList[2].Title}: ${bookList[2].Price}");
        }

        public static void DateTimeChapter(Logger logger)
        {
            DateTime now = DateTime.UtcNow;
            DateNtimespan dateNtimespan = new DateNtimespan(now, now.AddHours(1), logger);
            dateNtimespan.passedDuration();
            Console.WriteLine("{0} minutes passed.", dateNtimespan.passedDuration());
        }

        public static void StringChapter(Logger logger)
        {
            StringNStringBuilder stringNStringBuilder = new StringNStringBuilder("Sinni Singla", logger);
            //Console.WriteLine("I am '{0}'", stringNStringBuilder.getFirstName());
            //stringNStringBuilder.changeName("Shanky Singla");

            float f = 10.12f;
            //Console.WriteLine(f.ToString("C2"));

            stringNStringBuilder.replaceFirstName("Shanky");
        }
    }
}
