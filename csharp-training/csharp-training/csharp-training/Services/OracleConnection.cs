﻿namespace csharp_training.Services
{
    internal class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeOut)
            : base(connectionString, timeOut)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle conn open");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle conn close");
        }
    }
}
