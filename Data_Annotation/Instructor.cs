using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.Data_Annotation
{
    internal class Instructor
    {
        [Key]
        public int InsID { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bouns { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        [ForeignKey("Department")]
        public int DeptID { get; set; }
        public Department Department { get; set; }

        public List<CourseInst> CourseInsts { get; set; }

    }
}
