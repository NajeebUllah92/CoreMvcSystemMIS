using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InsStudentEmployment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Department { get; set; }
        public string PostBps { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
    }
}
