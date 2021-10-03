using System;
using System.Collections.Generic;

#nullable disable

namespace TutorialEntityFrameworkCore.Models
{
    public partial class Course
    {
        public Course()
        {
            StudentCourses = new HashSet<StudentCourse>();
            Teachers = new HashSet<Teacher>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
