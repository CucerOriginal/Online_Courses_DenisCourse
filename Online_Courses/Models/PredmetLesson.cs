using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class PredmetLesson
    {
        public int Id { get; set; }

        public string? PredmetName { get; set; }

        public int TeachedId { get; set; }
    }
}
