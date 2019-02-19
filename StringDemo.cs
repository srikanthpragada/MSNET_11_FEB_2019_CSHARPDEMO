using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string s1 = "C# Language";
            string s2 = "Asp.Net";

            Console.WriteLine(s2.Insert(s2.Length,"MVC"));
            Console.WriteLine(s2);

        }
    }
}
