using System;
using System.Collections.Generic;

namespace RegistrationOnCourses
{
    public partial class UsersOnCourse
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? UsersId { get; set; }
    }
}
