using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.convention
{
    internal class Instructor
    {
        public int InsID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bouns { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public int DeptID { get; set; }
        public Department Department { get; set; }

        // Many-to-Many
        public List<CourseInst> CourseInsts { get; set; }

    }
}
