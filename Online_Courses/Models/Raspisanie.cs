using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class Raspisanie
    {
        public int Id { get; set; }

        public int StudentGroupId { get; set; }

        public int PredmetLessonId { get; set; }

        public DateTime StartLesson { get; set; }

        public DateTime EndLesson { get; set; }
    }
}
