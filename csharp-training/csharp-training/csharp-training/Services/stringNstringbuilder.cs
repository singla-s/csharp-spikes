using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Services
{
    internal class StringNStringBuilder
    {
        public string name { get; set; }
        public StringNStringBuilder(string name)
        {
            this.name = name;
        }

        public string getFirstName()
        {
            return name.Substring(0, name.IndexOf(" "));
        }

        public void changeName(string name)
        {
            string prevName = this.name;
            if(!String.IsNullOrWhiteSpace(name))
            {
                this.name = name;
                Console.WriteLine("Name is changed from '{0}' to '{1}'", prevName, this.name);
            }
            else
            {
                Console.WriteLine("Name change failed due to invalid request!!!");
            }
        }
    }
}
