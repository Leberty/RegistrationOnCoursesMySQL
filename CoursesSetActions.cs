using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationOnCourses
{
    public partial class CoursesSet
    {
        public void printCourses()
        {
            using (registration_on_coursesContext db = new registration_on_coursesContext())
            {
                var courses = db.CoursesSets.ToList();
                foreach (CoursesSet c in courses)
                {
                    Console.WriteLine($"{c.Id}. {c.CourseName} {c.CourseCountHours} {c.CourseStart} - {c.CourseFinish}");
                }
            }
        }
    }
}
