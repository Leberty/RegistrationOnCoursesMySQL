using System;
using System.Collections.Generic;

namespace RegistrationOnCourses
{
    public partial class CoursesSet
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = null!;
        public string? CourseCountHours { get; set; }
        public DateOnly? CourseStart { get; set; }
        public DateOnly? CourseFinish { get; set; }
    }
}
