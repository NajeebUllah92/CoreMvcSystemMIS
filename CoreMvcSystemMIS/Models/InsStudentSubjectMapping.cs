﻿using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InsStudentSubjectMapping
    {
        public int Id { get; set; }
        public int EnrollmentId { get; set; }
        public int SubjectId { get; set; }
    }
}
