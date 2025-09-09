using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.convention
{
    internal class StudCourse
    {
        public int StudID { get; set; }
        public Student Student { get; set; }
        public int CourID { get; set; }
        public Course Course { get; set; }
        public int Grade { get; set; }

    }
}
