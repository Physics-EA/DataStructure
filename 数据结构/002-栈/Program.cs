using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<char> stack = new Stack<char>();
            //IStackDS<char> stack = new SeqStack<char>(30);
            IStackDS<char> stack = new LinkStack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine(stack.Count);
            char temp = stack.Pop();
            Console.WriteLine(temp);
            Console.WriteLine(stack.Count);
            char temp2 = stack.Peek();
            Console.WriteLine(temp2);
            Console.WriteLine(stack.Count);
            stack.Clear();
            Console.WriteLine(stack.Count);

            Console.ReadKey();
        }
    }
}
