using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesni_zadachi_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //syzdava masiv s 10 elementa ot celochislen tip
            //i inicializira vseki element sus stoynost ravna na indeksa na elementa umnojen po 5

            int[] bz = new int[10];
            for (int i = 0;i < bz.Length;i++)
            {
                bz[i] = i * 5;
                Console.WriteLine(bz[i]);
            }

        }
    }
}
