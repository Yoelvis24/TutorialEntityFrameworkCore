using System;
using System.Collections.Generic;

#nullable disable

namespace TutorialEntityFrameworkCore.Models
{
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public int? CourseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }

        public virtual Course Course { get; set; }
    }
}
