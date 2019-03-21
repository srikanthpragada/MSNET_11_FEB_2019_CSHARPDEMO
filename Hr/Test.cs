using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Hr
{
    public class Test
    {
        public static void Main(string[] args)
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            foreach(var e in ctx.Employees)
            {
                Console.WriteLine($"{e.EmpName} - {e.Salary} - {e.Department.DeptName}");
            }
        }
    }

}
