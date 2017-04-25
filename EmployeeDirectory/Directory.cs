using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Directory
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(string name, int salary, int age)
        {
            var employee = new Employee(name, salary, age);
            employees.Add(employee);
        }

        public void ListEmployees()
        {
            Console.WriteLine("Anställda:");
            int c = 0;
            foreach (var e in employees)
            {
                Console.WriteLine("{0} {1}", c, e);
                c++;
            }
/*            for (int i = 0; i < employees.Count; i++)
            {
               // Console.WriteLine(i + " " + employees[i]);
                Console.WriteLine("{0} {1}", i, employees[i]);
            }
*/
        }
    }
}
