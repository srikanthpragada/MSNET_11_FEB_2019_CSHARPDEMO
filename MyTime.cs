using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class MyTime
    {
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }
    }

    class TestTime
    {
        static void Main(string[] args)
        {
            MyTime t = new MyTime();
            t.Hours = 10;
            t.Mins = 20;
            t.Secs = 30;

            MyTime t2 = new MyTime { Hours = 30, Mins = 20, Secs = 30 };

        }
    }
}
