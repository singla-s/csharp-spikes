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
            if(!string.IsNullOrWhiteSpace(name))
            {
                this.name = name;
                writeName(prevName, this.name);
            }
            else
            {
                Console.WriteLine("Name change failed due to invalid request!!!");
            }
        }

        public void replaceFirstName(string name)
        {
            string prevName = this.name;
            if (!string.IsNullOrWhiteSpace(name))
            {
                int firstNameEndIndex = prevName.IndexOf(" ");
                StringBuilder fullNameBuilder = new StringBuilder();
                fullNameBuilder.Append(name);
                fullNameBuilder.Append(" ");
                fullNameBuilder.Append(this.name.Substring(firstNameEndIndex + 1));
                writeName(prevName, fullNameBuilder.ToString());
            }
            else
            {
                Console.WriteLine("Name change failed due to invalid request!!!");
            }
        }

        public void writeName(string prevName, string newName)
        {
            Console.WriteLine("Name is changed from '{0}' to '{1}'", prevName, newName);
        }
    }
}
