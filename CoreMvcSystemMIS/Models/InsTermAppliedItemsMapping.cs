using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InsTermAppliedItemsMapping
    {
        public int Id { get; set; }
        public int TermId { get; set; }
        public int FeeItemId { get; set; }
    }
}
