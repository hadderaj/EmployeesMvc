using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter a E-mail adress")]
        [EmailAddress(ErrorMessage ="Not a valid E-mail")]
        public string Email { get; set; }
    }
}
