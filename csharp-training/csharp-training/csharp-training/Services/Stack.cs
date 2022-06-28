using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Services
{
    internal class MyStack
    {
        public ArrayList stack { get; }
        public MyStack()
        {
            stack = new ArrayList();
        }

        public void Push(object ele)
        {
            if (ele == null)
            {
                throw new InvalidOperationException();
            }
            stack.Add(ele);
        }

        public object Pop()
        {
            var ele = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return ele;
        }

        // Written only to check correctness
        public void PrintAll()
        {
            Console.WriteLine(String.Join(',', stack.ToArray()));
        }
    }
}
