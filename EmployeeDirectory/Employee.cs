using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            var str =  Name + ", " + Salary + " kr";
            if (Age > 0) {
                str += " (" + Age + " år gammal)";
            }
            return str;
        }
        public Employee(string name, int salary, int age)
        {
            Name = name;
            Salary = salary;
            Age = age;
        }
        public Employee(string name, int salary) : this(name, salary, 0) {}
    }
}
