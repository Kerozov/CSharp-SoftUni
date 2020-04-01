using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => this.Count > 0 ? false : true;

        public Stack<string> AddRange(Stack<string> stack)
        {
            foreach (var item in stack)
            {
                this.Push(item);
            }

            return this;
        }
    }
}
