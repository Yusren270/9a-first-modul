using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopulnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi duljina na masiva:");
            int n=int.Parse(Console.ReadLine());
            int[]arr= new int[n];   
            int s = 1, bs = 0, l = 0,be=1;
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] =int.Parse( Console.ReadLine());
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    s++;
                    if (s > be)
                    {
                        be = s;
                        l = i + 1;
                        bs = l - be + 1;
                    }

                }
                else
                {
                    s = 1;

                }
            }
                for(int i=bs; i<be+bs;i++)
                {
                Console.Write("{0}, ",  arr[i]);
                }
            }
        }
    }

