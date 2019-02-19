using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    abstract class Doctor
    {
        private string name, dept;
        public Doctor(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.dept);
        }

        public abstract int GetSalary();
    }

    class Resident : Doctor 
    {
        protected int salary;
        public Resident(string name, string dept, int salary) : base(name,dept)
        {
            this.salary = salary;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.salary);
        }

        public override int GetSalary()
        {
            return this.salary; 
        }
    }

    class Consultant : Doctor
    {
        protected int visits, charge;
        public Consultant(string name, string dept, int visits, int charge)
            : base(name, dept)
        {
            this.visits = visits;
            this.charge = charge;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.visits);
            Console.WriteLine(this.charge);
        }

        public override int GetSalary()
        {
            return this.visits * this.charge;
        }
    }

    class TestDoctor
    {
        static void Main(string[] args)
        {
            Doctor d = new Resident("Dr. Joe", "Card", 400000);
            d.Print();  // Runtime Polymorphism 
            Console.WriteLine(d.GetSalary());  // Runtime Polymorphsim
            d = new Consultant("Dr. Adam", "Ped", 10, 1000);
            d.Print();  // Runtime Polymorphism 
        }
    }
}
