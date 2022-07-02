using csharp_training.Features;

namespace csharp_training.Handlers
{
    public class CompareHandler
    {
        public void ExecuteHandler()
        {
            Person personA = new Person("Sinni", 29);
            Person personB = new Person("Shanky", 30);
            Person older = personA.CompareTo(personB) == 1 ? personA : personB;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string response = $"{older.Name} is the older out of {personA.Name} and {personB.Name}.";
            Console.WriteLine(response);
        }
    }
}
