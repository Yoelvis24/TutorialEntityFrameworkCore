using System;
using System.Collections.Generic;

#nullable disable

namespace TutorialEntityFrameworkCore.Models
{
    public partial class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public int? StudentId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }
}
