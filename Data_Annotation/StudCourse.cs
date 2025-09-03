using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.Data_Annotation
{
    internal class StudCourse
    {
        [Key,Column(Order =0)]
        public int StudID { get; set; }
        [Key,Column(Order =1)]
        public int CourID { get; set; }
        public int Grade { get; set; }

    }
}
