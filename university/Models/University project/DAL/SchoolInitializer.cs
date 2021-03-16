using System;
using System.Collections.Generic;
using university.Models.University_project.Entities;

namespace university.Models.University_project.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Komal",LastName="Gaikwad",EnrollmentDate=DateTime.Parse("2021-15-03")},
            new Student{FirstMidName="Sunita",LastName="Khatkale",EnrollmentDate=DateTime.Parse("2021-15-03")},
            new Student{FirstMidName="Anu",LastName="Anand",EnrollmentDate=DateTime.Parse("2021-15-03")},
            new Student{FirstMidName="Sunita",LastName="Shinde",EnrollmentDate=DateTime.Parse("2021-15-03")},
            new Student{FirstMidName="Swapnil",LastName="More",EnrollmentDate=DateTime.Parse("2021-15-03")},
            new Student{FirstMidName="Sachin",LastName="Narale",EnrollmentDate=DateTime.Parse("2021-15-03")},
            new Student{FirstMidName="Saurabha",LastName="Norman",EnrollmentDate=DateTime.Parse("2021-15-03")},
            new Student{FirstMidName="Neema",LastName="Gaikwad",EnrollmentDate=DateTime.Parse("2021-15-03")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Computer",Credits=3,},
            new Course{CourseID=4022,Title="Mechanical",Credits=3,},
            new Course{CourseID=4041,Title="Electronic",Credits=3,},
            new Course{CourseID=1045,Title="Electrical",Credits=4,},
            new Course{CourseID=3141,Title="Civil",Credits=4,},
            new Course{CourseID=2021,Title="IT",Credits=3,},
            new Course{CourseID=2042,Title="Science",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}