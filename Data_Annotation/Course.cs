using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.Data_Annotation
{
    internal class Course
    {
        [Key]
        public int CourID { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Topic")]
        public int TopID { get; set; }

        public Topic Topic { get; set; }

        public List<StudCourse> StudCourses { get; set; }
        public List<CourseInst> CourseInsts { get; set; }
    }
}
