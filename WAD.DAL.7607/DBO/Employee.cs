using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WAD.DAL._7607.DBO
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public EmpGender Gender { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        
        public Department Department { get; set; }

        [Display(Name = "Cafe")]
        public int CafeId { get; set; }

        public Cafe Cafe { get; set; }

        [Required]
        public string Email { get; set; }

    }
    public enum EmpGender
    {
        Male,
        Female
    }
}
