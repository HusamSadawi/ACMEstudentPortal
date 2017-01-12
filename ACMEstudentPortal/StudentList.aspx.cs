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
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Student> getStudents([Control] Gender?
gender)
        {
            StudentContext db = new StudentContext();
            IQueryable<Student> query = db.students;

            if (gender  != null)
            {
                query = query.Where(s => s.sex == gender);
            }

            return query;
        }
      
        public void updateStudent(int studentID)
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

        public void deleteStudent(int studentID)
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
    }
}