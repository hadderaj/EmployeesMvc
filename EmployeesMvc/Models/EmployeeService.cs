using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesMvc.Models
{
    public class EmployeeService
    {
        List<Employee> employees = new List<Employee>();
        int employeeCount = 0;
        public void AddEmployee(Employee employee)
        {
            employee.Id = employeeCount++;
            employees.Add(employee);
        }

        public Employee[] GetAllEmployees()
        {
            var emp = employees
                .ToArray();

            return emp;
        }

        public Employee GetEmployeeById(int id)
        {
            var x = employees
                .Where(x => x.Id == id)
                .Single();
            return x;
                
        }
    }
}
