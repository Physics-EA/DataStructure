using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    class Node<T>
    {
        private T data;
        public T Data { get { return data; } set { data = value; } }
        private Node<T> next;
        public Node<T> Next { get { return next; } set { next = value; } }        

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T data)
        {
            this.data = data;
            next = null;
        }

        public Node(T data, Node<T> next)
        {
            this.data = data;
            next = null;
        }


        public Node(Node<T> next)
        {
            this.next = next;
            data = default(T);
        }

    }
}
