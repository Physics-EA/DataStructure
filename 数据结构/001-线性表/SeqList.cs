using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    class SeqList<T> : IListDS<T>
    {
        private T[] data;
        private int count = 0;

        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }

        public SeqList() : this(10) { }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        //添加元素
        public void Add(T item)
        {
            if (count >= data.Length)
            {
                Console.WriteLine("当前顺序表已经存满，不允许再存入");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        //清空
        public void Clear()
        {
            count = 0;
        }

        //删除
        public T Delete(int index)
        {
            T temp = data[index];
            for (int i = index + 1; i < count - 1; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
            return temp;
        }

        //取值，根据索引器
        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }

        //获得顺序表的长度
        public int GetLength()
        {
            return count;
        }

        //插入
        public void Insert(T item, int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        //判断顺序表是否为空
        public bool isEmpty()
        {
            return count == 0;
        }

        //获取元素所在的位置
        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
