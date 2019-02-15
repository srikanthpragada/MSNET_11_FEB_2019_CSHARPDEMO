using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Factors
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(args[0]);

            for (int i = 2; i <= num / 2; i++)
                if (num % i == 0)
                    Console.WriteLine(i);
        }
    }
}
