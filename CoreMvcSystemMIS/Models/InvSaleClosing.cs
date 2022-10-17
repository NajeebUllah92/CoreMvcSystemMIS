﻿using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class InvSaleClosing
    {
        public int Id { get; set; }
        public int CashierId { get; set; }
        public DateTime? OpeningDateTime { get; set; }
        public DateTime? ClosingDateTime { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsReceived { get; set; }
        public string Remarks { get; set; }
        public int ReceivedBy { get; set; }
        public decimal TellAmount { get; set; }
        public int FiscalYearId { get; set; }
    }
}