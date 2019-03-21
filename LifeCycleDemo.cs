using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class LifeCycleDemo
    {
        static void Main(string[] args)
        {
            TrainingEntities ctx = new TrainingEntities();
            ctx.Database.Log = Console.WriteLine;

            /**  life cycle of addition **/
            //Course c = new Course { Title = "Java EE", Duration = 40, Fee = 6000 };
            //Console.WriteLine(ctx.Entry(c).State);
            //ctx.Courses.Add(c);
            //Console.WriteLine(ctx.Entry(c).State);
            //ctx.SaveChanges();
            //Console.WriteLine(ctx.Entry(c).State);

            /** Life cylce of updation **/
            var c = ctx.Courses.Find(1002);
            Console.WriteLine(ctx.Entry(c).State); // Unchanged
            c.Fee = 5000;
            Console.WriteLine(ctx.Entry(c).State); // Modified 
            Console.WriteLine(c.GetType().FullName);
            Console.WriteLine(ObjectContext.GetObjectType(c.GetType()));

        }
    }
}
