using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracStudentApplication.Models
{
    public class Student
    {
        [Display(Name ="Name")]
        public string StuName { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string StuEmail { get; set; }
        [Display(Name = "Marks")]
        public int StuMarks { get; set; }
        [Key]
        [Display(Name = "ID")]
        public int StuId { get; set; }
    }
}