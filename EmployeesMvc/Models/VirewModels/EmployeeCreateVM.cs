using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesMvc.Models.VirewModels
{
    public class EmployeeCreateVM
    {
        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter a E-mail adress")]
        [EmailAddress(ErrorMessage = "Not a valid E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter somehting")]
        [Range(4,4)]
        public int Botcheck { get; set; }

    }
}
