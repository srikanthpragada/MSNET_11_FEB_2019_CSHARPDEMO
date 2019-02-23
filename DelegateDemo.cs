using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class DelegateDemo
    {
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            int[] a = { 10, 15, 20, 25, 30 };

            // var res  = Array.FindAll(a, IsEven);
            var res = Array.FindAll(a, n => n % 2 == 0);
            foreach (int v in res)
                Console.WriteLine(v);
        }
    }
}
