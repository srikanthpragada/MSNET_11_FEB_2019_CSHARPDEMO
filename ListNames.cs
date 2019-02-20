using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ListNames
    {
        static void Main(string[] args)
        {
            string s; 
            string [] names;

            Console.Write("Enter names separated by comma : ");
            s = Console.ReadLine();

            names = s.Split(',');

            foreach (string w in names)
                Console.WriteLine(w.ToUpper());


        }
    }
}
