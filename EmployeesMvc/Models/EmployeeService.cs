using EmployeesMvc.Models.Entities;
using EmployeesMvc.Models.VirewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesMvc.Models
{
    public class EmployeeService
    {
        
        MyContext context;
        public EmployeeService(MyContext myContext)
        {
            context = myContext;
        }
        public void AddEmployee(EmployeeCreateVM employeeCreateVM)
        {

            context.Employees.Add( new Employee
            {
                Name= employeeCreateVM.Name,
                Email=employeeCreateVM.Email
            });
            context.SaveChanges();
        }


        public EmployeeIndexVM[] GetAllEmployees()
        {
            var emp = context.Employees
                .Select(x => new EmployeeIndexVM { 
                    Id = x.Id,
                    Name= x.Name, 
                    Email=x.Email,
                    ShowAsHighlighted=x.Email.StartsWith("admin")} )
                .ToArray();
                
            return emp;
        }

        public EmployeeIndexVM GetEmployeeById(int id)
        {
            var x = context.Employees
                .Where(x => x.Id == id)
                .Single();
            return x;
        }
    }
}
