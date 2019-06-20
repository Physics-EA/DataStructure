using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    class LinkList<T> : IListDS<T>
    {
        private Node<T> head;

        public LinkList()
        {
            head = null;
        }

        public T this[int index]
        {
            get
            {
                Node<T> temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }

                return temp.Data;
            }
        }

        //添加
        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (true)
                {

                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                temp.Next = newNode;
            }
        }


        //清空
        public void Clear()
        {
            head = null;
        }

        //删除
        public T Delete(int index)
        {
            T data = default(T);

            if (index == 0)
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> curNode = temp.Next;
                data = curNode.Data;
                Node<T> nextNode = temp.Next;
                preNode.Next = nextNode;
            }
            return data;
        }

        //获得元素
        public T GetEle(int index)
        {
            return this[index];
        }

        //获取长度
        public int GetLength()
        {
            if (head == null) { return 0; }

            Node<T> temp = head;
            int count = 1;
            while (true)
            {
                if (temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        //插入
        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> curNode = temp.Next;
                preNode.Next = newNode;
                newNode.Next = curNode;
            }
        }

        //判断是否为空
        public bool isEmpty()
        {
            return head == null;
        }

        //定位位置
        public int Locate(T value)
        {
            Node<T> temp = head;
            if (temp == null)
            {
                return -1;
            }
            else
            {
                int index = 0;
                while (true)
                {
                    if (temp.Data.Equals(value))
                    {
                        return index;
                    }
                    else
                    {
                        if (temp.Next != null)
                        {
                            temp = temp.Next;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return -1;
            }
        }
    }
}
