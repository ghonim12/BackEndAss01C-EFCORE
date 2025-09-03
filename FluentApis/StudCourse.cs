using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.FluentApis
{
    internal class StudCourse
    {
        public int StudID { get; set; }
        public int CourID { get; set; }
        public int Grade { get; set; }

    }
}
