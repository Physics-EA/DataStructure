using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            SeqList<string> seqList = new SeqList<string>();
           // LinkList<string> seqList = new LinkList<string>();

            seqList.Add("123");
            seqList.Add("456");
            seqList.Add("789");

            Console.WriteLine(seqList.GetEle(0));
            Console.WriteLine(seqList[0]);
            seqList.Insert("777", 1);           

            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.Write(seqList[i] + " ");
            }
            Console.WriteLine();

            seqList.Delete(0);

            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.Write(seqList[i] + " ");
            }
            Console.WriteLine();

            seqList.Clear();

            Console.WriteLine(seqList.GetLength());

            Console.ReadKey();

        }
    }
}
