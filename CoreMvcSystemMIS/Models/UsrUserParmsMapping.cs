using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class UsrUserParmsMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ParmId { get; set; }
        public string ParmType { get; set; }
        public int BranchId { get; set; }
    }
}
