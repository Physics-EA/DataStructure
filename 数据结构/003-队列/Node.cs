using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    class Node<T>
    {
        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        private Node<T> next;
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(T data)
        {
            this.data = data;
        }


    }
}
