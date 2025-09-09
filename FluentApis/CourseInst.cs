using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.FluentApis
{
    public class CourseInst
    {
        public int InstID { get; set; }
        public Instructor Instructor { get; set; }
        public int CourID { get; set; }
        public Course Course { get; set; }
        public string Evaluate { get; set; }
    }
}
