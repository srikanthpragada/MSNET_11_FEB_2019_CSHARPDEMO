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
        public int TotalSeconds
        {
            get
            {
                return this.Hours * 3600 + this.Mins * 60 + this.Secs;
            }
        }

        public override bool Equals(object obj)
        {
            MyTime other = obj as MyTime; // Downcasting - object to MyTime
            return this.TotalSeconds == other.TotalSeconds;
        }

        public override string ToString()
        {
            return String.Format("{0:00}:{1:00}:{2:00}",
                                  this.Hours,this.Mins,this.Secs); 
        }
    }

    class TestTime
    {
        static void Main(string[] args)
        {
            MyTime t1 = new MyTime { Hours = 1, Mins = 20, Secs = 30 };
            MyTime t2 = new MyTime { Hours = 10, Mins = 20, Secs = 30 };

            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1);  // t1.ToString() 

        }
    }
}
