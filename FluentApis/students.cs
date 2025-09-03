using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.FluentApis
{
    internal class Student
    {
        public int StudID { get; set; }
        public string FName { get; set; }
        public string LName{ get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int DeptID { get; set; }
    }
}
