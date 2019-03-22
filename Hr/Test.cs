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

            //foreach(var e in ctx.Employees.Include("Department"))
            //{
            //    Console.WriteLine(e.GetType().Name);
            //    Console.WriteLine($"{e.EmpName} - {e.Salary} - {e.Department.DeptName}");
            //}

            var depts = from d in ctx.Departments
                        where d.Employees.Count() > 1
                        select d;

            foreach (var d in depts)
                Console.WriteLine(d.DeptName);


            //foreach (var d in ctx.Departments)
            //{
            //    Console.WriteLine($"{d.DeptName}");
            //    Console.WriteLine("----------------");
            //    foreach (var e in d.Employees)
            //    {
            //        Console.WriteLine(e.EmpName);
            //    }
            //}
        }
    }

}
