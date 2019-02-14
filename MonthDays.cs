using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class MonthDays
    {
        static void Main()
        {
            int month, year, nodays;

            Console.Write("Enter month number :");
            month = Int32.Parse(Console.ReadLine());

            switch(month)
            {
                case 2:
                    Console.Write("Enter year : ");
                    year = Int32.Parse(Console.ReadLine());
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                       nodays = 29;
                    else
                       nodays = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11: nodays = 30; break;
                default: nodays = 31; break; 
            }

            Console.WriteLine("No. of days for {0} is {1}", month,nodays);
        }
    }
}
