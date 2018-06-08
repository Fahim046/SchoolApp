using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolApp.Models
{
    public class Assignments
    {
        [Key]
        public int AssignmentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AssignmentName { get; set; }
              
        public Courses Course { get; set; }
        public Students Student { get; set; }
        
    }
}