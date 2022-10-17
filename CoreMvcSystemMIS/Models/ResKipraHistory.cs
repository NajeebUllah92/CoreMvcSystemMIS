using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class ResKipraHistory
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string InvoiceNo { get; set; }
        public int OrderId { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public double InvoiceTotal { get; set; }
        public double TaxCalculated { get; set; }
        public string Ntn { get; set; }
        public string KipraKey { get; set; }
        public string Status { get; set; }
        public int FiscalYearId { get; set; }
    }
}
