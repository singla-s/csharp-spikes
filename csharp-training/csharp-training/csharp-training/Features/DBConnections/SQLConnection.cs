namespace csharp_training.Features
{
    public class SQLConnection : DBConnection
    {
        public SQLConnection(string connectionString, TimeSpan timeOut)
            : base(connectionString, timeOut)
        {

        }

        public override void Open()
        {
            Console.WriteLine("SQL conn open");
        }

        public override void Close()
        {
            Console.WriteLine("SQL conn close");
        }
    }
}
