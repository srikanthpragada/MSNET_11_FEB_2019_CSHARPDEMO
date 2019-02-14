using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Numbers
    {
        static void Main()
        {

            Console.Write("Enter a number :");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i += 2)
                Console.WriteLine(i);
        }
    }
}
