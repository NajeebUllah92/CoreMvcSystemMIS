using System;
using System.Collections.Generic;

namespace CoreMvcSystemMIS.Models
{
    public partial class TempInsStudent
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ClassId { get; set; }
        public string RegistrationNo { get; set; }
        public int? BatchId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string PermanentAddress { get; set; }
        public DateTime? Dob { get; set; }
        public string Nationality { get; set; }
        public int ReligionId { get; set; }
        public int QualificationId { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public int InstitutionId { get; set; }
        public string Gender { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string PhotoName { get; set; }
        public string StudentContact { get; set; }
        public string FatherContact { get; set; }
        public string Cnic { get; set; }
        public string EmailAddress { get; set; }
        public string PostalAddress { get; set; }
        public string BloodGroup { get; set; }
        public string FatherProfession { get; set; }
        public string GuardianContact { get; set; }
        public int AdmissionId { get; set; }
        public int BranchId { get; set; }
        public string Status { get; set; }
        public string PlcNo { get; set; }
        public int DomicileId { get; set; }
        public int JoiningSessionId { get; set; }
        public string GuardianName { get; set; }
        public int? FeeGroupId { get; set; }
        public int? FeeTermId { get; set; }
        public int? CategoryId { get; set; }
        public int? HostelId { get; set; }
        public int? ShiftId { get; set; }
        public int? TransportId { get; set; }
        public int SectionId { get; set; }
        public int? FamilyId { get; set; }
        public bool IsDeleted { get; set; }
        public int CityId { get; set; }
    }
}
