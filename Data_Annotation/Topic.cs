using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.Data_Annotation
{
    internal class Topic
    {
        [Key]
        public int TopID { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
