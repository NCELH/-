using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static int zuiDa(int[] a)
        {
            int temp = 0, max = 0, n;
            n = a.Length;
            for (int i = 0; i < n; i++)
            {
                temp = a[i];
                for (int j = i + 1; j < n; j++)
                {
                    temp += a[j];
                    if (temp > max) max = temp;
                }
            }
            if (max < 0) max = 0;
            return max;
        }
        static void Main(string[] args)
        {
            int max;
            int[] array = new int[] { -2, 11, -4, 13, -5, -2 };
            max = zuiDa(array);
	        Console.WriteLine(max);
            Console.ReadKey();//防止闪退
        }
    }
}
