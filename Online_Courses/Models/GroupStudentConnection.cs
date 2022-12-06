using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class GroupStudentConnection
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int GroupId { get; set; }
    }
}
