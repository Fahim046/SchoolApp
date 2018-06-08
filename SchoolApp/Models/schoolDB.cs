using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolApp.Models
{
    public class SchoolDB : DbContext
    { 
       public SchoolDB() : base ("MySchoolDb")
       {
            
       } 

        public DbSet<Teachers> Teacher { get; set; }
        public DbSet<Students> Student { get; set; }
        public DbSet<Courses> Course { get; set; }
        public DbSet<Assignments> Assignment { get; set; }



    }
}