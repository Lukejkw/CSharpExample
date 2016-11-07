using CSharpExample.Contracts;
using CSharpExample.Entities;
using CSharpExample.Repositories;
using System;

namespace CSharpExample
{
    internal class Program
    {
        private static readonly IRepository<Employee> EmployeeRepo = new EmployeeRepository();

        private static void Main(string[] args)
        {
            DisplayEmployees();

            EmployeeRepo.Insert(new Employee() { Name = "Paige" });
            EmployeeRepo.Insert(new Employee() { Name = "Guy" });

            DisplayEmployees();
        }

        private static void DisplayEmployees()
        {
            var empList = EmployeeRepo.GetAll();
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}