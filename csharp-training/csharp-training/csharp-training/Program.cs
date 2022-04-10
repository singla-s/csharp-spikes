using csharp_training.Services;

namespace CSharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DateTime and Timespan Block
            DateTime now = DateTime.UtcNow;
            DateNtimespan dateNtimespan = new DateNtimespan(now, now.AddHours(1));
            dateNtimespan.passedDuration();
            Console.WriteLine("{0} minutes passed.", dateNtimespan.passedDuration());

            //String and String Builder
            StringNStringBuilder stringNStringBuilder = new StringNStringBuilder("Sinni Singla");
            Console.WriteLine("I am '{0}'",stringNStringBuilder.getFirstName());
            stringNStringBuilder.changeName("Shanky Singla");
        }
    }
}
