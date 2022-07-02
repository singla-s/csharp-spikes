using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Features
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object? obj)
        {
            if(obj == null) return 1;
            return Age > (obj as Person)?.Age ? 1 : -1;
        }
    }
}
