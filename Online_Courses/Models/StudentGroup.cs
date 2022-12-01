using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class StudentGroup
    {
        public int Id { get; set; }

        public string? GroupName { get; set; }

        public IList<Student>? Students { get; set; }
    }
}
