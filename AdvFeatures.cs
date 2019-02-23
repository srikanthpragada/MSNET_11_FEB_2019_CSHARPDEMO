using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class AdvFeatures
    {
        static void Main(string[] args)
        {
            var n = new MyTime { Hours = 10, Mins = 20, Secs = 30 };
            var person = new { Name = "Abc", Age = 30 };
            Console.WriteLine(person.Name);

            dynamic d = "Abc";
            Console.WriteLine(d.Length);

            String name = "C#";

            Console.WriteLine($"Name = {name}");

        }
    }
}
