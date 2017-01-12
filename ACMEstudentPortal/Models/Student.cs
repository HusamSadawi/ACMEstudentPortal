using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ACMEstudentPortal.Models
{

    public enum Gender
    {
    Male,
    Female
    }
    public class Student
    {

        //We use this class so we can handle each row in the database as an entity, 
        //this will allow to work with the database without having to worry about data access
        //and handling the code as objects only.
        [ScaffoldColumn(false), Display(Name ="ID")]
        public int studentID { get; set; }

        [Required, StringLength(50), Display(Name = "Name")]
        public string name { get; set; }

        [Required, Display(Name = "Sex")]
        public Gender sex { get; set; }

        [Required, Display(Name = "Email"), EmailAddress(ErrorMessage = "Email Address is Invalid")]
        public string email { get; set; }

        [Required, Display(Name = "Birth Date"), DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }

        [Required, StringLength(50), Display(Name = "Nationality")]
        public string nationality { get; set; }

        [Required, StringLength(12), Display(Name = "Mobile")]
        public string mobile { get; set; }

        [Required, StringLength(50), Display(Name = "Course")]
        public string course { get; set; }

        [Display(Name = "Graduation Year")]
        public int graduationYear { get; set; }

        [Required, StringLength(50), Display(Name = "Major")]
        public string major { get; set; }


       

    }
}