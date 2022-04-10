using csharp_training.Services;

namespace CSharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DateTime and Timespan Block
            dateTimeChapter();

            //String and String Builder
            stringChapter();
        }

        public static void dateTimeChapter()
        {
            DateTime now = DateTime.UtcNow;
            DateNtimespan dateNtimespan = new DateNtimespan(now, now.AddHours(1));
            dateNtimespan.passedDuration();
            Console.WriteLine("{0} minutes passed.", dateNtimespan.passedDuration());
        }

        public static void stringChapter()
        {
            StringNStringBuilder stringNStringBuilder = new StringNStringBuilder("Sinni Singla");
            //Console.WriteLine("I am '{0}'", stringNStringBuilder.getFirstName());
            //stringNStringBuilder.changeName("Shanky Singla");

            float f = 10.12f;
            //Console.WriteLine(f.ToString("C2"));

            stringNStringBuilder.replaceFirstName("Shanky");
        }
    }
}
