using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOP_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = Math.Pow(2, 1.0 / 12);
            double r2 =Math.Pow(10,Math.Log10(2)/12);
            double tone = 500;
            int[] intarr = new int[12];
            for (int i =0;i<intarr.Length;i++)
            {
                //type cast fra en type til en anden (int) til (double)
                intarr[i] =(int)tone;
                Console.WriteLine(intarr[i]);
                tone *= r;
            }
            Console.Beep(intarr[2],100);
            Console.Beep(intarr[3], 100);
            Console.Beep(intarr[10], 100);

                Console.ReadKey();
        }
    }
}
