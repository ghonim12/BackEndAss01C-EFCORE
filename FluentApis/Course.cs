using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.FluentApis
{
    public class Course
    {
        public int CourID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        // FK
        public int TopID { get; set; }
        public Topic Topic { get; set; }

        // Many-to-Many
        public List<StudCourse> StudCourses { get; set; }
        public List<CourseInst> CourseInsts { get; set; }
    }
}
