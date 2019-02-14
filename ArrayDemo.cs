using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int [] a = new int[5];  // Initialized with 0s

            for (int i = 0; i < 5; i++)
                Console.WriteLine(a[i]);

        }
    }
}
