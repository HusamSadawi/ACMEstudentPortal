

using System.Collections.Generic;
using System.Data.Entity;
namespace ACMEstudentPortal.Models
{
    public class StudentsDBInistializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            GetStudents().ForEach(c => context.students.Add(c));
        }


        private static List<Student> GetStudents()
        {
            var students = new List<Student> {
    new Student
    {
        studentID = 1,
        name = "Husam",
        sex = Gender.Male,
        email = "husam.alsaadawi@hotmail.com",
        dateOfBirth = new System.DateTime(1994,12,12),
        nationality = "Palestinian",
        mobile = "0504553069",
        course = "CCIS",
        graduationYear = 1994,
        major = "Software Engineering"
    }
 };
            return students;
        }
   
 }
}