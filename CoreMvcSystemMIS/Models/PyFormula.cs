using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class PyFormula
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string FormulaCode { get; set; }
        public bool IsActive { get; set; }
        public string FormulaSection { get; set; }
    }
}
