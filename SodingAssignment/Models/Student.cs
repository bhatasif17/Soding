using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SodingAssignment.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Mobile { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Gender")]
        public int GenderId { get; set; }
        public IEnumerable<SelectListItem> Gender { get; set; }
    }

}