using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InsPayChallanDetail
    {
        public int Id { get; set; }
        public int ChallanMasterId { get; set; }
        public decimal NetAmount { get; set; }
        public int FeeItemPostedId { get; set; }
        public string ItemFeeDescription { get; set; }
        public string ItemSource { get; set; }
    }
}
