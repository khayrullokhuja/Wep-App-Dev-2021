using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WAD.DAL._7607.DBO
{
    public class Cafe
    {
        public int CafeId { get; set; }
        [Display(Name = "Branch Name")]
        [Required]
        public string CafeName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
