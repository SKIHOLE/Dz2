using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("B", "A");
            emp.CalculateSalary(3, "Developer");

            Console.ReadKey();
        }
    }
    class Employee
    {
        private string firstName;
        private string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void CalculateSalary(int yearsOfExperience, string position)
        {
            double salary;
            double tax;
            switch (position)
            {
                case "Manager":
                    salary = 40000 + (yearsOfExperience * 2000);
                    break;
                case "Developer":
                    salary = 50000 + (yearsOfExperience * 3000);
                    break;
                default:
                    salary = 25000 + (yearsOfExperience * 1000);
                    break;
            }
            tax = salary * 0.1;

            Console.WriteLine("Employee information:");
            Console.WriteLine("Name:"+ firstName+" "+lastName);
            Console.WriteLine("Position:"+ position);
            Console.WriteLine("Salary:"+ salary);
            Console.WriteLine("Tax:"+ tax);
        }
    }

   
}
