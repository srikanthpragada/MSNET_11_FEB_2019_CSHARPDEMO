using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class OutDemo
    {
        static void Main(string[] args)
        {
            int n;

            Zero(out n);
        }

        static void Zero(out int v)
        {
            v = 0;
        }
    }
}
