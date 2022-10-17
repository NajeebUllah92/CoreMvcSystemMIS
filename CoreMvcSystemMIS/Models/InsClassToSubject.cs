using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InsClassToSubject
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
    }
}
