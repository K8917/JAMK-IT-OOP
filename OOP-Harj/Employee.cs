using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public Employee() { }
        public Employee(string name)
        {
            Name = name;
        }
        public Employee(string name, string profession, int salary)
            : this(name)
        {
            Profession = profession;
            Salary = salary;
        }

        public virtual void Tulosta()
        {
            Console.WriteLine("Employee:");
            Console.WriteLine(" - Name: " + Name + ", Profession: " + Profession + ", Salary: " + Salary);
            Console.WriteLine();
        }
    }

    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }
        public Boss() { }
        public Boss(string name, string profession, int salary, string car, int bonus)
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        public override void Tulosta()
        {
            Console.WriteLine("Boss:");
            Console.WriteLine(" - Name: " + Name + ", Profession: " + Profession + ", Salary: " + Salary + ", Car: " + Car + ", Bonus: " + Bonus);
            Console.WriteLine();
        }
    }
}
