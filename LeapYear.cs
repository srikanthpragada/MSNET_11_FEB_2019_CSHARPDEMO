using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter year : ");
            string line = Console.ReadLine();
            int year = Int32.Parse(line);

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("{0} is Leap Year",year);
            else
                Console.WriteLine("{0} is not a Leap Year", year);
        }
    }
}
