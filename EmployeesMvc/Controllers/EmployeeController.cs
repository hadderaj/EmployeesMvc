using EmployeesMvc.Models;
using EmployeesMvc.Models.Entities;
using EmployeesMvc.Models.VirewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesMvc.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService service;
        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }

        [Route("")]
        public IActionResult Index()
        {
            var employess = service.GetAllEmployees();
            return View(employess);
        }

        [Route("createemployee")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Route("createemployee")]
        [HttpPost]
        public IActionResult Create(EmployeeCreateVM employeeCreateVM)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeCreateVM);
            }
            service.AddEmployee(employeeCreateVM);
            return RedirectToAction(nameof(Index));
        }

        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            var emp =service.GetEmployeeById(id);
            return View(emp);
        }
    }
}
