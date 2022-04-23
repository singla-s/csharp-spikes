using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Services
{
    public class Logger
    {
       public void log(string logMsg)
        {
            Console.WriteLine($"{DateTime.Now}: {logMsg}");
        }
    }
}
