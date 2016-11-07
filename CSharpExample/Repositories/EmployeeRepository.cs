using CSharpExample.Contracts;
using CSharpExample.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExample.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Luke" },
            new Employee() { Id = 2, Name = "Steph" }
        };

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee Update(Employee employee)
        {
            var toUpdate = _employees.FirstOrDefault(e => e.Id == employee.Id);
            if (toUpdate != null)
            {
                toUpdate.Name = employee.Name;
                toUpdate.PositionTypeId = employee.PositionTypeId;
            }
            return toUpdate;
        }

        public Employee Insert(Employee employee)
        {
            employee.Id = _employees.Count;
            _employees.Add(employee);
            return employee;
        }

        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }
    }
}