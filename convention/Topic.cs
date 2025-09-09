using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.convention
{
    internal class Topic
    {
        public int TopID { get; set; }
        public string Name { get; set; }

        // One-to-Many
        public List<Course> Courses { get; set; }
    }
}
