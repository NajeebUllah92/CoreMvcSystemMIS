using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class Table2ItemList
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}
