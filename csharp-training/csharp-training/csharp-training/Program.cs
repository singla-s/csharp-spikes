using csharp_training.Handlers;

namespace CSharpTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EventNDelegateHandler handler = new EventNDelegateHandler();
            handler.executeHandler();
        }
    }
}
