using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ACMEstudentPortal.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("ACMEstudentPortal")
        {
        }
        public DbSet<Student> students { get; set; }
    }
}