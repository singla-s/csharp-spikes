using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Services
{
    internal abstract class DBConnection
    {
        string _connectionString;
        TimeSpan _timeout;

        public DBConnection(string connectionString, TimeSpan timeout)
        {
            if(connectionString == null || connectionString.Length == 0)
            {
                throw new ArgumentNullException();
            }
            _connectionString = connectionString;
            _timeout = timeout;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
