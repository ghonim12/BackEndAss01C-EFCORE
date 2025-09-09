using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.convention
{
    internal class Student
    {
        public int StudID { get; set; }
        public string FName { get; set; }
        public string LName{ get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int DeptID { get; set; }
        public Department Departments { get; set; }
        public List<StudCourse> StudCourses { get; set; }
    }
}
