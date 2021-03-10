using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesMvc.Models
{
    public class EmployeeService
    {
        static List<Employee> employees = new List<Employee>();
        static int employeeCount = 0;
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
    }
}
