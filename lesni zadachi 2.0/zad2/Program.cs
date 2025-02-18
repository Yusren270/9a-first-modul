using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n=int.Parse(Console.ReadLine());
            int[] bz = new int[n];
            //vhod
            for (int i = 0; i < n; i++)
            {

                bz[i] = int.Parse(Console.ReadLine());
            }
            int[] bz1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                bz1[i]=int.Parse(Console.ReadLine());
                
            }
                //izhod
                for (int i = 0; i < n; i++)
                {
                   
                    if (bz[i] == bz1[i])
                    {
                        Console.WriteLine("chislata sa ednakvi chisloto e " + bz);
                    }
                    else
                    {
                        Console.WriteLine("ne sa ednakvi");
                    }
           }
        }
    }
}
