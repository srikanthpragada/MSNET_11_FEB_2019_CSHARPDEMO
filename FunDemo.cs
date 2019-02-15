using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class FunDemo
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[10];

            Change(ref n);
            Console.WriteLine(n);  // ??

            Fill(arr,1);            //  Fill array with 1s
            Fill(arr,1,5);          //  Fill only first 5 elements with 1
            Fill(arr);              //  Fill whole array with 0s 
            Fill(arr, size: 5);     //  Fill first 5 elements with 0s
        }

        static void Change(ref int v)
        {
            v = 0;
        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Fill(int [] a, int value = 0, int size = -1)
        {
            if (size == -1)
                size = a.Length;

            for (int i = 0; i < size; i++)
                a[i] = value; 
        }


        static int Multiply(int n1 = 10 ,int n2 = 2)
        {
            return n1 * n2;
        }
    }
}

