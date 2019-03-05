using System;
using System.Collections.Generic;
using System.IO;

namespace csharpdemo
{
    class SortMobileNumbers
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"e:\classroom\msnet\feb11\mobiles.txt");
            var mobiles = new SortedSet<string>();
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;

                string[] numbers = line.Split(',');
                foreach (string n in numbers)
                    if (n.Length == 10)
                        mobiles.Add(n);
            }
            sr.Close();

            foreach(string n in mobiles)
                Console.WriteLine(n);
        }
    }
}
