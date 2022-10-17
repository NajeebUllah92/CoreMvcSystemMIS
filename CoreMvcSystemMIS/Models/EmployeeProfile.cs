using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcSystemMIS.Models
{
    public class EmployeeInfo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string EmployeeName { get; set; }
        public int? CategoryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int? ReligionId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public DateTime? DateOfJoin { get; set; }
        //public TimeSpan? StartTime { get; set; }
        //public TimeSpan? EndTime { get; set; }
        public int? Weekholiday { get; set; }
        public int? Status { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? QualificationId { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? BranchId { get; set; }
        public int? LedgerId { get; set; }
        public string PayrollType { get; set; }
        public int? BasicPayScale { get; set; }
        public string Nic { get; set; }
        public int? CurrentStage { get; set; }
        public string LinkCode { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAvailForCreditLimit { get; set; }
        public decimal FnsdLimitBalance { get; set; }
        public string EmployeeGroup { get; set; }
        public string EmpReligion { get; set; }
        public string DepartName { get; set; }
        public string DesigName { get; set; }
        public string BankName { get; set; }
    }
}
