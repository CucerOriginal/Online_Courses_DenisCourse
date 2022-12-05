using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string? SecondName { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public DateOnly Birthday { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public int? StudentGroupId { get; set; }

        public int CoursesListId { get; set; }
    }
}
