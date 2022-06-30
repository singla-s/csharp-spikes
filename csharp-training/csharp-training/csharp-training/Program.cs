using csharp_training.Services;

namespace CSharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DBConnection sqlConnection = new SQLConnection("hello", new TimeSpan());
            sqlConnection.Open();
            sqlConnection.Close();

            DBConnection oracleConnection = new OracleConnection("hello2", new TimeSpan());
            oracleConnection.Open();
            oracleConnection.Close();
        }

        public static void dateTimeChapter(Logger logger)
        {
            DateTime now = DateTime.UtcNow;
            DateNtimespan dateNtimespan = new DateNtimespan(now, now.AddHours(1), logger);
            dateNtimespan.passedDuration();
            Console.WriteLine("{0} minutes passed.", dateNtimespan.passedDuration());
        }

        public static void stringChapter(Logger logger)
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
