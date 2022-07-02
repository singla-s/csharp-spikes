using csharp_training.Handlers;

namespace CSharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CompareHandler handler = new CompareHandler();
            handler.ExecuteHandler();
        }
    }
}
