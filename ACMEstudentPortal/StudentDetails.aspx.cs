using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACMEstudentPortal.Models;
using System.Web.ModelBinding;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace ACMEstudentPortal
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        static StudentContext _db = new ACMEstudentPortal.Models.StudentContext();
        IQueryable<Student> query = _db.students;
        int currentID;
        public IQueryable<Student> getStudent([QueryString("studentID")] int?
studentID)
        {

            if (studentID.HasValue && studentID > 0)
            {
                query = query.Where(p => p.studentID == studentID);
                currentID = (int)studentID;
            }
            else
            {
                query = null;
            }

            return query;
        }
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        public void studentDetailsUpdate(int studentID)
        {
            using (StudentContext db = new StudentContext())
            {
                Student item = null;
                item = db.students.Find(studentID);
                if (item == null)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} was not found", studentID));
                    return;
                }

                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }

        public void studentDetailsDelete(int studentID)
        {
            using (StudentContext db = new StudentContext())
            {
                var item = new Student { studentID = studentID };
                db.Entry(item).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} no longer exists in the database.", studentID));
                }
            }
        }

        /*      protected void updateDetails(object sender, EventArgs e)
              {

                  using (_db)
                  {
                      try
                      {
                          var student = (from c in _db.students where c.studentID == currentID select c).First();
                          if (student != null)
                          {
                              student.name = textName.Text.Trim();
                              student.email = textEmail.Text.Trim();
                              student.dateOfBirth = Convert.ToDateTime(textDate.Text.Trim());
                              student.sex = textGender.Text.Trim();
                              student.nationality = textNationality.Text.Trim();
                              student.mobile = textMobile.Text.Trim();
                              student.course = textCourse.Text.Trim();
                              student.major = textMajor.Text.Trim();
                              student.graduationYear = textGraduation.Text.Trim();
                          }
                      }
                  }
              }
          }*/
    }
}