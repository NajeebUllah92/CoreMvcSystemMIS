using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InsQuotaSetting
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public int CategoryId { get; set; }
        public int NoOfSeats { get; set; }
    }
}
