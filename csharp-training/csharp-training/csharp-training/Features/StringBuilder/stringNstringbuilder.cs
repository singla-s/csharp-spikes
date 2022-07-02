using csharp_training.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Features
{
    public class StringNStringBuilder
    {
        private readonly Logger _logger;

        public string name { get; set; }
        public StringNStringBuilder(string name, Logger logger)
        {
            this.name = name;
            _logger = logger;
        }

        public string getFirstName()
        {
            return name.Substring(0, name.IndexOf(" "));
        }

        public void changeName(string name)
        {
            string prevName = this.name;
            if (!string.IsNullOrWhiteSpace(name))
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
            _logger.log($"Name is changed from '{prevName}' to '{newName}'");
        }
    }
}
