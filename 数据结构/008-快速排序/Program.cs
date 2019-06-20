using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_快速排序
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            QuickSort(data,0,data.Length-1);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.ReadKey();
        }

        static void QuickSort(int[] dataArray, int left, int right)
        {
            if (left < right)
            {
                int x = dataArray[left];
                int i = left;
                int j = right;

                while (true && i < j)
                {
                    //从后往前
                    while (true && i < j)
                    {
                        if (dataArray[j] <= x)
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }

                    //从前往后
                    while (true && i < j)
                    {
                        if (dataArray[i] > x)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                dataArray[i] = x;
                QuickSort(dataArray, left, i - 1);
                QuickSort(dataArray, i + 1, right);
            }
        }
    }
}
