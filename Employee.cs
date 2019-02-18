using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Employee
    {
        // Instance variables 
        private int id;
        private string name;
        private int salary;
        private static int hraper = 30;
        public static int GetHraper()
        {
            return hraper;
        }
        //Constructor 
        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        // static constructor 
        static Employee()
        {
            Console.WriteLine("Loading classs");
        }

        public void Print()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
            Console.WriteLine(salary); // this.salary
        }
        public int GetNetSalary()
        {
            return this.salary + (this.salary * hraper / 100);
        }
        public void Hike(int amount)
        {
            this.salary += amount;
        }

        public string Fullname
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && value.Length > 0)
                    this.name = value;
            }
        }

    }
        class TestEmployee
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee(1, "Mr. Bill", 50000);  // Instance or Object 
                e1.Fullname = "Gates";
                e1.Print();
            }

        }
    }
