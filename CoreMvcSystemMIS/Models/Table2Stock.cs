using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class Table2Stock
    {
        public string Itemcode { get; set; }
        public string Descr { get; set; }
        public string CategorKey { get; set; }
        public string Category { get; set; }
        public decimal? Prate { get; set; }
        public decimal? Srate { get; set; }
    }
}
