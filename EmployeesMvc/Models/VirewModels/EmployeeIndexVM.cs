﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesMvc.Models.VirewModels
{
    public class EmployeeIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public bool ShowAsHighlighted { get; set; }



    }
}
