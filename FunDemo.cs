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
            //Console.WriteLine(Add(10, 20));
            //Console.WriteLine(Multiply(10, 20));
            //Console.WriteLine(Multiply(20));  // 40
            //Console.WriteLine(Multiply());    // 20
            //Console.WriteLine(Multiply(n2:10));    // 20

            int n = 10;
            Change(ref n);
            Console.WriteLine(n);  // ??
        }

        static void Change(ref int v)
        {
            v = 0;
        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Multiply(int n1 = 10 ,int n2 = 2)
        {
            return n1 * n2;
        }
    }
}

