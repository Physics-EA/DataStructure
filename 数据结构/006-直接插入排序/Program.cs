using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_直接插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            InsertSort(data);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.ReadKey();
        }

        static void InsertSort(int[] dataArray)
        {
            
            for (int i = 1; i < dataArray.Length; i++)
            {
                int iValue = dataArray[i];
                bool isInsert = false;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (dataArray[j] > iValue)
                    {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else
                    {
                        dataArray[j + 1] = iValue;
                        isInsert = true;
                        break;
                    }
                }
                if (isInsert == false)
                {
                    dataArray[0] = iValue;
                }

            }
           

        }
    }
}
