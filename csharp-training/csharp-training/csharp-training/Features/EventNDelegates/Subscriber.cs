namespace csharp_training.Features
{
    internal class Subscriber
    {
        public void SendNotification(object src, EventArgs args)
        {
            Console.WriteLine($"Event invoked from {src} -> Notification Sent!!!");
        }
    }
}
