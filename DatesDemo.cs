using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class DatesDemo
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime sd = new DateTime(2019, 1, 1);

            Console.WriteLine(sd);     // dt.ToString() 
            Console.WriteLine(today);  // dt.ToString() 

            TimeSpan  ts = today.Subtract(sd);
            Console.WriteLine("No. of days past is {0}", ts.Days);
        }
    }
}
