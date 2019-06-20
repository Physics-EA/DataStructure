using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top;
        private int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        //情况栈
        public void Clear()
        {
            count = 0;
            top = null;
        }

        //取得栈的长度
        public int GetLength()
        {
            return count;
        }

        //判断栈中是否为空
        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            return top.Data;
        }

        //出栈
        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        //入栈
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
    }
}
