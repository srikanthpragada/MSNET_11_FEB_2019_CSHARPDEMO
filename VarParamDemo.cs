using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class VarParamDemo
    {
        static void Main(string[] args)
        {
            PrintNames("A", "B", "C", "D");
            PrintNames("A", "B");
            PrintNames("A", "B", "C", "D","E");
        }

        static void PrintNames(params string [] names)
        {
            foreach(string n in names)
              Console.WriteLine(n);
        }
    }
}


