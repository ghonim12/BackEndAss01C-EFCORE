using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.FluentApis
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public int InsID { get; set; }
    }
}
