using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    public class ManipulateCourse
    {
        static void Main(string[] args)
        {
            TrainingEntities ctx = new TrainingEntities();
            ctx.Database.Log = Console.WriteLine;

            /***** Insertion - Add course to COURSES table using INSERT command ****/
            //Course c = new Course { Title = "Java SE", Fee = 4000, Duration = 36 };
            //ctx.Courses.Add(c);
            //ctx.SaveChanges();

            /***** List courses - SELECT  *****/
            //foreach (Course c in ctx.Courses)
            //    Console.WriteLine(c.Title);

            /***** Update FEE of a course   ****/
            //var course = ctx.Courses.Find(1004);
            //if (course == null)
            //    Console.WriteLine("Sorry! Course not found!");
            //else
            //{
            //    Console.WriteLine(course.Title);
            //    course.Fee = course.Fee + 500;
            //    ctx.SaveChanges(); 
            //}


            /***** Delete object from COURSES table *****/
            //var course = ctx.Courses.Find(1004);
            //if (course == null)
            //    Console.WriteLine("Sorry! Course not found!");
            //else
            //{
            //    ctx.Courses.Remove(course);
            //    ctx.SaveChanges();
            //}


            /****  Query ***/
            var courses = from c in ctx.Courses
                          where c.Fee > 5000
                          orderby c.Fee
                          select new { Title = c.Title, Fee = c.Fee * 0.9 };

            foreach (var c in courses)
                Console.WriteLine(c.Title);

        }
    }
}
