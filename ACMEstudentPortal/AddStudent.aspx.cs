using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using ACMEstudentPortal.Models;
namespace ACMEstudentPortal
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addStudent(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string email = textEmail.Text.Trim();
            DateTime date = Convert.ToDateTime(textDate.Text.Trim());
            string gender = textGender.Text.Trim();
            string nationality = textNationality.Text.Trim();
            string mobile = textMobile.Text.Trim();
            string course = textCourse.Text.Trim();
            string major = textMajor.Text.Trim();
            string graduation = textGraduation.Text.Trim();

           Student c =  new Student
            {
                name = name,
                sex = (Gender)Enum.Parse(typeof(Gender), gender, true),
                email = email,
                dateOfBirth = date,
                nationality = nationality,
                mobile = mobile,
                course = course,
                graduationYear = Convert.ToInt16(graduation),
                major = major
            };

            using (var _db = new ACMEstudentPortal.Models.StudentContext())
            {
                _db.students.Add(c);
                _db.SaveChanges();
            }

         

            Response.Redirect("SuccessfulAddition.aspx");
        }

      
    }
}