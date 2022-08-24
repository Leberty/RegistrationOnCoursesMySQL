using System;
using System.Collections.Generic;

namespace RegistrationOnCourses
{
    public partial class User
    {
        public int Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Midname { get; set; } = null!;
        public string? EduLevel { get; set; }
    }
}
