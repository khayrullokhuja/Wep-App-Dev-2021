using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WAD.DAL._7607.DBO
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Display(Name = "Department Name")]
        [Required]
        public string DepartmentName { get; set; }
    }
}
