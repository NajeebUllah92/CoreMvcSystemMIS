﻿using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InsFeeGroupFeeItemsMapping
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int FeeItemId { get; set; }
        public decimal FeeRate { get; set; }
    }
}
