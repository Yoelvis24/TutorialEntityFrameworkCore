using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TutorialEntityFrameworkCore.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentAddresses = new HashSet<StudentAddress>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        [Key]
        public int StudentId { get; set; }
        public int? GradeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual ICollection<StudentAddress> StudentAddresses { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
