using System;

namespace Inheritance
{
    class Employee
    {
        protected int Id;
        protected string Name;
        protected DateTime Dob;
        protected double Salary;

        public Employee(int id, string name, DateTime dob, double salary)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Salary = salary;
        }

        public virtual double ComputeSalary()
        {
            return Salary;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nDOB: {Dob.ToShortDateString()}\nSalary: {ComputeSalary()}");
        }

    }

    class Manager:Employee
    {
        private double OnsiteAllowance;
        private double Bonus;

        public Manager(int id, string name, DateTime dob, double salary, double onsiteAllowance, double bonus)
        : base(id, name, dob, salary) 
        {
            OnsiteAllowance = onsiteAllowance;
            Bonus = bonus;
        }
        public override double ComputeSalary()
        {
            return Salary + OnsiteAllowance + Bonus;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Onsite Allowance: {OnsiteAllowance}\nBonus: {Bonus}\nTotal Salary: {ComputeSalary()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee(101, "John Doe", new DateTime(1990, 5, 15), 50000);
            Console.WriteLine("Employee Details:");
            emp.DisplayDetails();

            Console.WriteLine("\n--------------------------\n");

            Manager mgr = new Manager(102, "Alice Smith", new DateTime(1985, 3, 10), 70000, 10000, 15000);
            Console.WriteLine("Manager Details:");
            mgr.DisplayDetails();
        }
    }
}
