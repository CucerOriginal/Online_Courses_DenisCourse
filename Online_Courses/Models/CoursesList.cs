using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class CoursesList
    {
        public int Id { get; set; }

        public string? CourseName { get; set; }

        public int Cost { get; set; }

        public int NumberClasses { get; set; }
    }
}
