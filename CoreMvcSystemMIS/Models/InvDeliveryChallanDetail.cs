﻿using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InvDeliveryChallanDetail
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
    }
}
