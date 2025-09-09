using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.Data_Annotation
{
    internal class Student
    {
        [Key]
        public int StudID { get; set; }
        [Required, MaxLength(50)]
        public string FName { get; set; }
        [Required, MaxLength(50)]
        public string LName{ get; set; }
        public string Address { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
        // Many-to-Many
        public List<StudCourse> StudCourses { get; set; }
    }
}
