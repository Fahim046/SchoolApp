using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolApp.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }

        
        public Teachers AssignedTo { get; set; }
        public List<Students> Student { get; set; }
        public List<Assignments> Assignment { get; set; }

    }
}