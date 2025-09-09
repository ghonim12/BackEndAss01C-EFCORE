using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.FluentApis
{
    public class Department
    {
        public int DeptID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        // رئيس القسم
        public int Ins_ID { get; set; }
        public Instructor Instructor { get; set; }

        // Relations
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}
