using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.Data_Annotation
{
    internal class Department
    {
        [Key]
        public int DeptID { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        [ForeignKey("Instructor")]
        public int InsID { get; set; }
    }
}
