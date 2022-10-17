using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreMvcSystemMIS.Models
{
    public partial class cmsnet_cms_uat_dbContext : DbContext
    {
        public cmsnet_cms_uat_dbContext(DbContextOptions<cmsnet_cms_uat_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccAccount> AccAccounts { get; set; }
        public virtual DbSet<AccAccountHead> AccAccountHeads { get; set; }
        public virtual DbSet<AccAccountsMapping> AccAccountsMappings { get; set; }
        public virtual DbSet<AccBudgetDetail> AccBudgetDetails { get; set; }
        public virtual DbSet<AccBudgetMaster> AccBudgetMasters { get; set; }
        public virtual DbSet<AccFiscalYear> AccFiscalYears { get; set; }
        public virtual DbSet<AccGroupAccount> AccGroupAccounts { get; set; }
        public virtual DbSet<AccReconciliation> AccReconciliations { get; set; }
        public virtual DbSet<AccType> AccTypes { get; set; }
        public virtual DbSet<AccVoucherDetail> AccVoucherDetails { get; set; }
        public virtual DbSet<AccVoucherMaster> AccVoucherMasters { get; set; }
        public virtual DbSet<AccVoucherNumbringSeries> AccVoucherNumbringSeries { get; set; }
        public virtual DbSet<AccVouchersLedger> AccVouchersLedgers { get; set; }
        public virtual DbSet<GenCity> GenCities { get; set; }
        public virtual DbSet<GenDomicile> GenDomiciles { get; set; }
        public virtual DbSet<GenImage> GenImages { get; set; }
        public virtual DbSet<GenTermsAndCondition> GenTermsAndConditions { get; set; }
        public virtual DbSet<HrmCategory> HrmCategories { get; set; }
        public virtual DbSet<HrmDepartment> HrmDepartments { get; set; }
        public virtual DbSet<HrmDesignation> HrmDesignations { get; set; }
        public virtual DbSet<HrmEmployee> HrmEmployees { get; set; }
        public virtual DbSet<InsBatch> InsBatches { get; set; }
        public virtual DbSet<InsCenter> InsCenters { get; set; }
        public virtual DbSet<InsClass> InsClasses { get; set; }
        public virtual DbSet<InsClassFeeGroupsMapping> InsClassFeeGroupsMappings { get; set; }
        public virtual DbSet<InsClassToSubject> InsClassToSubjects { get; set; }
        public virtual DbSet<InsDiscipline> InsDisciplines { get; set; }
        public virtual DbSet<InsDivision> InsDivisions { get; set; }
        public virtual DbSet<InsExamination> InsExaminations { get; set; }
        public virtual DbSet<InsFeeGroup> InsFeeGroups { get; set; }
        public virtual DbSet<InsFeeGroupFeeItemsMapping> InsFeeGroupFeeItemsMappings { get; set; }
        public virtual DbSet<InsFeeItem> InsFeeItems { get; set; }
        public virtual DbSet<InsFeePost> InsFeePosts { get; set; }
        public virtual DbSet<InsFeePostMaster> InsFeePostMasters { get; set; }
        public virtual DbSet<InsFeeTerm> InsFeeTerms { get; set; }
        public virtual DbSet<InsInstitute> InsInstitutes { get; set; }
        public virtual DbSet<InsMeritFormula> InsMeritFormulas { get; set; }
        public virtual DbSet<InsMeritList> InsMeritLists { get; set; }
        public virtual DbSet<InsNotification> InsNotifications { get; set; }
        public virtual DbSet<InsNotificationType> InsNotificationTypes { get; set; }
        public virtual DbSet<InsPayChallan> InsPayChallans { get; set; }
        public virtual DbSet<InsPayChallanDetail> InsPayChallanDetails { get; set; }
        public virtual DbSet<InsProgram> InsPrograms { get; set; }
        public virtual DbSet<InsQualification> InsQualifications { get; set; }
        public virtual DbSet<InsQuotaSetting> InsQuotaSettings { get; set; }
        public virtual DbSet<InsRegistrationNumbringSeries> InsRegistrationNumbringSeries { get; set; }
        public virtual DbSet<InsReligion> InsReligions { get; set; }
        public virtual DbSet<InsSection> InsSections { get; set; }
        public virtual DbSet<InsSession> InsSessions { get; set; }
        public virtual DbSet<InsStudent> InsStudents { get; set; }
        public virtual DbSet<InsStudentAdmission> InsStudentAdmissions { get; set; }
        public virtual DbSet<InsStudentCateogry> InsStudentCateogries { get; set; }
        public virtual DbSet<InsStudentDup> InsStudentDups { get; set; }
        public virtual DbSet<InsStudentDupDup> InsStudentDupDups { get; set; }
        public virtual DbSet<InsStudentEmployment> InsStudentEmployments { get; set; }
        public virtual DbSet<InsStudentFeeMapping> InsStudentFeeMappings { get; set; }
        public virtual DbSet<InsStudentMeritListing> InsStudentMeritListings { get; set; }
        public virtual DbSet<InsStudentQualification> InsStudentQualifications { get; set; }
        public virtual DbSet<InsStudentSubjectMapping> InsStudentSubjectMappings { get; set; }
        public virtual DbSet<InsStudentTestScore> InsStudentTestScores { get; set; }
        public virtual DbSet<InsSubject> InsSubjects { get; set; }
        public virtual DbSet<InsTermAppliedItemsMapping> InsTermAppliedItemsMappings { get; set; }
        public virtual DbSet<InvCategory> InvCategories { get; set; }
        public virtual DbSet<InvCompany> InvCompanies { get; set; }
        public virtual DbSet<InvCustomer> InvCustomers { get; set; }
        public virtual DbSet<InvCustomerType> InvCustomerTypes { get; set; }
        public virtual DbSet<InvDeliveryChallanDetail> InvDeliveryChallanDetails { get; set; }
        public virtual DbSet<InvDeliveryChallanMaster> InvDeliveryChallanMasters { get; set; }
        public virtual DbSet<InvDemandNote> InvDemandNotes { get; set; }
        public virtual DbSet<InvDemandNoteDetail> InvDemandNoteDetails { get; set; }
        public virtual DbSet<InvGatePassInDetail> InvGatePassInDetails { get; set; }
        public virtual DbSet<InvGatePassInMaster> InvGatePassInMasters { get; set; }
        public virtual DbSet<InvJcMonthSetting> InvJcMonthSettings { get; set; }
        public virtual DbSet<InvLocation> InvLocations { get; set; }
        public virtual DbSet<InvPackageProductsMapping> InvPackageProductsMappings { get; set; }
        public virtual DbSet<InvPaymentType> InvPaymentTypes { get; set; }
        public virtual DbSet<InvProduct> InvProducts { get; set; }
        public virtual DbSet<InvProductBatch> InvProductBatches { get; set; }
        public virtual DbSet<InvProductLedger> InvProductLedgers { get; set; }
        public virtual DbSet<InvProductionDetail> InvProductionDetails { get; set; }
        public virtual DbSet<InvProductionMaster> InvProductionMasters { get; set; }
        public virtual DbSet<InvPurchaseDetail> InvPurchaseDetails { get; set; }
        public virtual DbSet<InvPurchaseMaster> InvPurchaseMasters { get; set; }
        public virtual DbSet<InvPurchaseOrderDetail> InvPurchaseOrderDetails { get; set; }
        public virtual DbSet<InvPurchaseOrderMaster> InvPurchaseOrderMasters { get; set; }
        public virtual DbSet<InvQuatationDetail> InvQuatationDetails { get; set; }
        public virtual DbSet<InvQuatationMaster> InvQuatationMasters { get; set; }
        public virtual DbSet<InvSaleClosing> InvSaleClosings { get; set; }
        public virtual DbSet<InvSaleClosingDetail> InvSaleClosingDetails { get; set; }
        public virtual DbSet<InvSaleDetail> InvSaleDetails { get; set; }
        public virtual DbSet<InvSaleMaster> InvSaleMasters { get; set; }
        public virtual DbSet<InvSalemanToRoutsMapping> InvSalemanToRoutsMappings { get; set; }
        public virtual DbSet<InvSchemeDetail> InvSchemeDetails { get; set; }
        public virtual DbSet<InvSchemeMaster> InvSchemeMasters { get; set; }
        public virtual DbSet<InvShift> InvShifts { get; set; }
        public virtual DbSet<InvStockAdjustment> InvStockAdjustments { get; set; }
        public virtual DbSet<InvStockAdjustmentDetail> InvStockAdjustmentDetails { get; set; }
        public virtual DbSet<InvStockTransfer> InvStockTransfers { get; set; }
        public virtual DbSet<InvStockTransferDetail> InvStockTransferDetails { get; set; }
        public virtual DbSet<InvThirdPartyCustomer> InvThirdPartyCustomers { get; set; }
        public virtual DbSet<InvUnit> InvUnits { get; set; }
        public virtual DbSet<InvVehicle> InvVehicles { get; set; }
        public virtual DbSet<InvVendor> InvVendors { get; set; }
        public virtual DbSet<InvWarehouse> InvWarehouses { get; set; }
        public virtual DbSet<OrgBranch> OrgBranches { get; set; }
        public virtual DbSet<OrgFeaturesMapping> OrgFeaturesMappings { get; set; }
        public virtual DbSet<OrgOrgSystemsMapping> OrgOrgSystemsMappings { get; set; }
        public virtual DbSet<OrgOrganization> OrgOrganizations { get; set; }
        public virtual DbSet<PyAdvanceLoanInfo> PyAdvanceLoanInfos { get; set; }
        public virtual DbSet<PyAllowanceMaster> PyAllowanceMasters { get; set; }
        public virtual DbSet<PyBasicPayDetail> PyBasicPayDetails { get; set; }
        public virtual DbSet<PyBasicPayMaster> PyBasicPayMasters { get; set; }
        public virtual DbSet<PyConveyanceAllowance> PyConveyanceAllowances { get; set; }
        public virtual DbSet<PyCorporateAllowanceMapping> PyCorporateAllowanceMappings { get; set; }
        public virtual DbSet<PyCorporateSalaryMaster> PyCorporateSalaryMasters { get; set; }
        public virtual DbSet<PyCpFundCalculation> PyCpFundCalculations { get; set; }
        public virtual DbSet<PyDeductionMaster> PyDeductionMasters { get; set; }
        public virtual DbSet<PyEmployeeDeductionMapping> PyEmployeeDeductionMappings { get; set; }
        public virtual DbSet<PyEmployeeDeductionMaster> PyEmployeeDeductionMasters { get; set; }
        public virtual DbSet<PyEmployeeSalaryAllowanceMapping> PyEmployeeSalaryAllowanceMappings { get; set; }
        public virtual DbSet<PyEmployeeSalaryMaster> PyEmployeeSalaryMasters { get; set; }
        public virtual DbSet<PyEmployeeTransaction> PyEmployeeTransactions { get; set; }
        public virtual DbSet<PyFormula> PyFormulas { get; set; }
        public virtual DbSet<PyHouseRentAllowanceSetting> PyHouseRentAllowanceSettings { get; set; }
        public virtual DbSet<PyPaymentSlip> PyPaymentSlips { get; set; }
        public virtual DbSet<PyPayrollGeneration> PyPayrollGenerations { get; set; }
        public virtual DbSet<PyPayrollGenerationDetail> PyPayrollGenerationDetails { get; set; }
        public virtual DbSet<PyPayrollGenerationMaster> PyPayrollGenerationMasters { get; set; }
        public virtual DbSet<PySalaryHead> PySalaryHeads { get; set; }
        public virtual DbSet<PyStaffAttendance> PyStaffAttendances { get; set; }
        public virtual DbSet<PyTaxDeductionPattern> PyTaxDeductionPatterns { get; set; }
        public virtual DbSet<ResBed> ResBeds { get; set; }
        public virtual DbSet<ResCurrencyNote> ResCurrencyNotes { get; set; }
        public virtual DbSet<ResCustomerTypeItemsMapping> ResCustomerTypeItemsMappings { get; set; }
        public virtual DbSet<ResFood> ResFoods { get; set; }
        public virtual DbSet<ResFoodAddon> ResFoodAddons { get; set; }
        public virtual DbSet<ResFoodAvailability> ResFoodAvailabilities { get; set; }
        public virtual DbSet<ResFoodCategory> ResFoodCategories { get; set; }
        public virtual DbSet<ResFoodToAddonsMapping> ResFoodToAddonsMappings { get; set; }
        public virtual DbSet<ResFoodVariant> ResFoodVariants { get; set; }
        public virtual DbSet<ResFoodVariantRecipe> ResFoodVariantRecipes { get; set; }
        public virtual DbSet<ResKipraHistory> ResKipraHistories { get; set; }
        public virtual DbSet<ResKitchen> ResKitchens { get; set; }
        public virtual DbSet<ResOrderType> ResOrderTypes { get; set; }
        public virtual DbSet<ResPackageVarientsMapping> ResPackageVarientsMappings { get; set; }
        public virtual DbSet<ResPatient> ResPatients { get; set; }
        public virtual DbSet<ResSaleClosing> ResSaleClosings { get; set; }
        public virtual DbSet<ResSaleClosingDetail> ResSaleClosingDetails { get; set; }
        public virtual DbSet<ResSaleDetail> ResSaleDetails { get; set; }
        public virtual DbSet<ResSaleDetailTemp> ResSaleDetailTemps { get; set; }
        public virtual DbSet<ResSaleMaster> ResSaleMasters { get; set; }
        public virtual DbSet<ResShift> ResShifts { get; set; }
        public virtual DbSet<ResTable> ResTables { get; set; }
        public virtual DbSet<ResVarientPricingByCustType> ResVarientPricingByCustTypes { get; set; }
        public virtual DbSet<ResWard> ResWards { get; set; }
        public virtual DbSet<SysControllesGroup> SysControllesGroups { get; set; }
        public virtual DbSet<SysErpDefaultSetting> SysErpDefaultSettings { get; set; }
        public virtual DbSet<SysExecptionLogging> SysExecptionLoggings { get; set; }
        public virtual DbSet<SysFeature> SysFeatures { get; set; }
        public virtual DbSet<SysForm> SysForms { get; set; }
        public virtual DbSet<SysHtml> SysHtmls { get; set; }
        public virtual DbSet<SysInvTypeWiseControll> SysInvTypeWiseControlls { get; set; }
        public virtual DbSet<SysLableContent> SysLableContents { get; set; }
        public virtual DbSet<SysLayout> SysLayouts { get; set; }
        public virtual DbSet<SysModule> SysModules { get; set; }
        public virtual DbSet<SysModuleFormsMapping> SysModuleFormsMappings { get; set; }
        public virtual DbSet<SysMonthName> SysMonthNames { get; set; }
        public virtual DbSet<SysOrgFormsMapping> SysOrgFormsMappings { get; set; }
        public virtual DbSet<SysOrgModulesMapping> SysOrgModulesMappings { get; set; }
        public virtual DbSet<SysSystem> SysSystems { get; set; }
        public virtual DbSet<SysWeekDay> SysWeekDays { get; set; }
        public virtual DbSet<SysYear> SysYears { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<Table2ItemList> Table2ItemLists { get; set; }
        public virtual DbSet<Table2Stock> Table2Stocks { get; set; }
        public virtual DbSet<TableBakemanCategory> TableBakemanCategories { get; set; }
        public virtual DbSet<TableMughalCarProduct> TableMughalCarProducts { get; set; }
        public virtual DbSet<TempInsStudent> TempInsStudents { get; set; }
        public virtual DbSet<UsrSystemUser> UsrSystemUsers { get; set; }
        public virtual DbSet<UsrUserBranchesMapping> UsrUserBranchesMappings { get; set; }
        public virtual DbSet<UsrUserFormsMapping> UsrUserFormsMappings { get; set; }
        public virtual DbSet<UsrUserParmsMapping> UsrUserParmsMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=66.219.22.159;database=cmsnet_cms_uat_db;User Id=cmsnet_cms_uat_usr; Password=Hmis@360;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("cmsnet_cms_uat_usr");

            modelBuilder.Entity<AccAccount>(entity =>
            {
                entity.ToTable("AccAccount", "dbo");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountName).HasMaxLength(200);

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OpeningBalanceCr).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpeningBalanceDr).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AccAccountHead>(entity =>
            {
                entity.ToTable("AccAccountHead", "dbo");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.HeadCode).HasMaxLength(10);

                entity.Property(e => e.HeadName).HasMaxLength(200);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AccAccountsMapping>(entity =>
            {
                entity.ToTable("AccAccountsMapping", "dbo");

                entity.Property(e => e.DebitOrCredit).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemBillType).HasMaxLength(20);

                entity.Property(e => e.MappingForm).HasMaxLength(100);

                entity.Property(e => e.MappingSource).HasMaxLength(50);

                entity.Property(e => e.PartnerType).HasMaxLength(20);

                entity.Property(e => e.TransactionType).HasMaxLength(20);
            });

            modelBuilder.Entity<AccBudgetDetail>(entity =>
            {
                entity.ToTable("AccBudgetDetail", "dbo");

                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EstimatedAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AccBudgetMaster>(entity =>
            {
                entity.ToTable("AccBudgetMaster", "dbo");

                entity.Property(e => e.BroughtForward).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GovernmentFund).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncreaseInPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdatedDate).HasColumnName("lastUpdatedDate");

                entity.Property(e => e.Other).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OwnResources).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AccFiscalYear>(entity =>
            {
                entity.ToTable("AccFiscalYear", "dbo");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<AccGroupAccount>(entity =>
            {
                entity.ToTable("AccGroupAccount", "dbo");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupCode).HasMaxLength(10);

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AccReconciliation>(entity =>
            {
                entity.ToTable("AccReconciliation", "dbo");

                entity.Property(e => e.BeginingBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BeginingDate).HasColumnType("date");

                entity.Property(e => e.ClearVouchers).HasMaxLength(500);

                entity.Property(e => e.Deposits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Payments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatmentEndingBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatmentEndingDate).HasColumnType("date");

                entity.Property(e => e.UnClearVouchers).HasMaxLength(500);
            });

            modelBuilder.Entity<AccType>(entity =>
            {
                entity.ToTable("AccType", "dbo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeCode).HasMaxLength(50);

                entity.Property(e => e.TypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<AccVoucherDetail>(entity =>
            {
                entity.ToTable("AccVoucherDetail", "dbo");

                entity.Property(e => e.AmountCredit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountDebit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Folio).HasMaxLength(300);

                entity.Property(e => e.MappingForm).HasMaxLength(50);

                entity.Property(e => e.MappingSource).HasMaxLength(50);

                entity.Property(e => e.PartnerType).HasMaxLength(20);

                entity.Property(e => e.ProductId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AccVoucherMaster>(entity =>
            {
                entity.ToTable("AccVoucherMaster", "dbo");

                entity.Property(e => e.BankAccountNo).HasMaxLength(200);

                entity.Property(e => e.BankName).HasMaxLength(300);

                entity.Property(e => e.ChequeDate).HasColumnType("date");

                entity.Property(e => e.ChequeNo).HasMaxLength(200);

                entity.Property(e => e.DebitableCreditable).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.JvFormType).HasMaxLength(10);

                entity.Property(e => e.PaidToReceivedFrom).HasMaxLength(500);

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VoucherStatus).HasMaxLength(10);

                entity.Property(e => e.VoucherType)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<AccVoucherNumbringSeries>(entity =>
            {
                entity.ToTable("AccVoucherNumbringSeries", "dbo");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.VoucherType)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<AccVouchersLedger>(entity =>
            {
                entity.ToTable("AccVouchersLedger", "dbo");

                entity.Property(e => e.AccountName).HasMaxLength(300);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PartnerType).HasMaxLength(20);

                entity.Property(e => e.VoucherType)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<GenCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GenCity", "dbo");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<GenDomicile>(entity =>
            {
                entity.ToTable("GenDomicile", "dbo");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<GenImage>(entity =>
            {
                entity.ToTable("GenImages", "dbo");

                entity.Property(e => e.ImageName).HasMaxLength(500);

                entity.Property(e => e.ImagePath).HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<GenTermsAndCondition>(entity =>
            {
                entity.ToTable("GenTermsAndConditions", "dbo");

                entity.Property(e => e.TextLine).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<HrmCategory>(entity =>
            {
                entity.ToTable("HrmCategory", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<HrmDepartment>(entity =>
            {
                entity.ToTable("HrmDepartment", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmDesignation>(entity =>
            {
                entity.ToTable("HrmDesignation", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ResFnsdAllowanceLimit).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<HrmEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HrmEmployee", "dbo");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BasicPayScale).HasDefaultValueSql("((-1))");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentGovt).HasMaxLength(500);

                entity.Property(e => e.CurrentStage).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateOfJoin).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DesignationId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Domicile)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmployeeGrade).HasMaxLength(100);

                entity.Property(e => e.EmployeeGroup).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(300);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FnsdLimitBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Gpid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GPID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsAvailForCreditLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDate1)
                    .HasMaxLength(200)
                    .HasColumnName("L_Date");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Ldate)
                    .HasColumnType("date")
                    .HasColumnName("LDate");

                entity.Property(e => e.LedgerId).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkCode).HasMaxLength(50);

                entity.Property(e => e.MaritalStatus).HasMaxLength(10);

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(100);

                entity.Property(e => e.Nic)
                    .HasMaxLength(50)
                    .HasColumnName("NIC");

                entity.Property(e => e.PDate)
                    .HasColumnType("date")
                    .HasColumnName("P_Date");

                entity.Property(e => e.PayrollType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'M')");

                entity.Property(e => e.Pdate1)
                    .HasMaxLength(200)
                    .HasColumnName("PDate");

                entity.Property(e => e.Phone).HasMaxLength(200);

                entity.Property(e => e.Qualification).HasMaxLength(50);

                entity.Property(e => e.Rdate)
                    .HasMaxLength(200)
                    .HasColumnName("RDate");

                entity.Property(e => e.ReligionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RetirementDate).HasColumnType("date");

                entity.Property(e => e.StateS)
                    .HasMaxLength(10)
                    .HasColumnName("State_S")
                    .IsFixedLength();

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UDate)
                    .HasColumnType("date")
                    .HasColumnName("U_Date");

                entity.Property(e => e.Udate1)
                    .HasMaxLength(200)
                    .HasColumnName("UDate");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Weekholiday).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InsBatch>(entity =>
            {
                entity.ToTable("InsBatch", "dbo");

                entity.Property(e => e.BatchName).HasMaxLength(200);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<InsCenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InsCenter", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InsClass>(entity =>
            {
                entity.ToTable("InsClass", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InsClassFeeGroupsMapping>(entity =>
            {
                entity.ToTable("InsClassFeeGroupsMapping", "dbo");
            });

            modelBuilder.Entity<InsClassToSubject>(entity =>
            {
                entity.ToTable("InsClassToSubjects", "dbo");
            });

            modelBuilder.Entity<InsDiscipline>(entity =>
            {
                entity.ToTable("InsDiscipline", "dbo");

                entity.Property(e => e.AdmissionExpiryDate).HasColumnType("date");

                entity.Property(e => e.AdmissionFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsAdmissionOpen).HasMaxLength(10);

                entity.Property(e => e.IsGovtEmploymentOption).HasMaxLength(10);

                entity.Property(e => e.IsMultipeCategory).HasMaxLength(10);

                entity.Property(e => e.IsQualiPercentageOnTotal).HasMaxLength(10);

                entity.Property(e => e.IsTestRequired)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Yes')");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.QualificationsRequired).HasMaxLength(100);

                entity.Property(e => e.TestFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TestMarksPercentage).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsDivision>(entity =>
            {
                entity.ToTable("InsDivision", "dbo");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PercentageFrom).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.PercentageTo).HasColumnType("numeric(6, 2)");
            });

            modelBuilder.Entity<InsExamination>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InsExamination", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InsFeeGroup>(entity =>
            {
                entity.ToTable("InsFeeGroup", "dbo");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsApplyChangesOnStudents)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InsFeeGroupFeeItemsMapping>(entity =>
            {
                entity.ToTable("InsFeeGroupFeeItemsMapping", "dbo");

                entity.Property(e => e.FeeRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsFeeItem>(entity =>
            {
                entity.ToTable("InsFeeItem", "dbo");

                entity.Property(e => e.DefaultValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FeeType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InsFeePost>(entity =>
            {
                entity.ToTable("InsFeePost", "dbo");

                entity.Property(e => e.AdditionalValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.NetValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusChangeRemarks).HasMaxLength(500);

                entity.Property(e => e.TermValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsFeePostMaster>(entity =>
            {
                entity.ToTable("InsFeePostMaster", "dbo");

                entity.Property(e => e.LastModifyBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PostingMethod)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PostingRemarks).HasMaxLength(500);
            });

            modelBuilder.Entity<InsFeeTerm>(entity =>
            {
                entity.ToTable("InsFeeTerm", "dbo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TermName).HasMaxLength(200);
            });

            modelBuilder.Entity<InsInstitute>(entity =>
            {
                entity.ToTable("InsInstitute", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InsMeritFormula>(entity =>
            {
                entity.ToTable("InsMeritFormula", "dbo");

                entity.Property(e => e.Perentage).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsMeritList>(entity =>
            {
                entity.ToTable("InsMeritList", "dbo");

                entity.Property(e => e.MeritListName).HasMaxLength(50);
            });

            modelBuilder.Entity<InsNotification>(entity =>
            {
                entity.ToTable("InsNotification", "dbo");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<InsNotificationType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InsNotificationType", "dbo");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InsPayChallan>(entity =>
            {
                entity.ToTable("InsPayChallan", "dbo");

                entity.Property(e => e.AmountAfterDueDate)
                    .HasMaxLength(14)
                    .HasColumnName("Amount_After_DueDate");

                entity.Property(e => e.AmountPaid)
                    .HasMaxLength(14)
                    .HasColumnName("Amount_Paid");

                entity.Property(e => e.AmountWithinDueDate)
                    .HasMaxLength(14)
                    .HasColumnName("Amount_Within_DueDate");

                entity.Property(e => e.BankMnemonic)
                    .HasMaxLength(200)
                    .HasColumnName("Bank_Mnemonic");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(1)
                    .HasColumnName("Bill_Status");

                entity.Property(e => e.BillingMonth)
                    .HasMaxLength(4)
                    .HasColumnName("Billing_Month");

                entity.Property(e => e.ChallanId).HasColumnName("challan_Id");

                entity.Property(e => e.ChallanNo).HasMaxLength(20);

                entity.Property(e => e.ChallanSource).HasMaxLength(100);

                entity.Property(e => e.CustomerDetail)
                    .HasMaxLength(30)
                    .HasColumnName("Customer_Detail");

                entity.Property(e => e.CustomerType).HasMaxLength(30);

                entity.Property(e => e.DatePaid)
                    .HasMaxLength(8)
                    .HasColumnName("Date_Paid");

                entity.Property(e => e.DueDate)
                    .HasMaxLength(8)
                    .HasColumnName("Due_Date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidSource).HasMaxLength(10);

                entity.Property(e => e.ReferenceChallanNo).HasMaxLength(50);

                entity.Property(e => e.Reserved).HasMaxLength(200);

                entity.Property(e => e.TranAuthId)
                    .HasMaxLength(6)
                    .HasColumnName("Tran_Auth_Id");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(8)
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.TransTime)
                    .HasMaxLength(6)
                    .HasColumnName("Trans_Time");

                entity.Property(e => e.TransactionAmount).HasMaxLength(14);
            });

            modelBuilder.Entity<InsPayChallanDetail>(entity =>
            {
                entity.ToTable("InsPayChallanDetail", "dbo");

                entity.Property(e => e.ItemFeeDescription).HasMaxLength(100);

                entity.Property(e => e.ItemSource).HasMaxLength(100);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsProgram>(entity =>
            {
                entity.ToTable("InsProgram", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.FeePostingType).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InsQualification>(entity =>
            {
                entity.ToTable("InsQualification", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<InsQuotaSetting>(entity =>
            {
                entity.ToTable("InsQuotaSettings", "dbo");
            });

            modelBuilder.Entity<InsRegistrationNumbringSeries>(entity =>
            {
                entity.ToTable("InsRegistrationNumbringSeries", "dbo");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InsReligion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InsReligion", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InsSection>(entity =>
            {
                entity.ToTable("InsSection", "dbo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Section).HasMaxLength(200);
            });

            modelBuilder.Entity<InsSession>(entity =>
            {
                entity.ToTable("InsSession", "dbo");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsAdmissionOpen).HasMaxLength(10);

                entity.Property(e => e.SessionName).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<InsStudent>(entity =>
            {
                entity.ToTable("InsStudent", "dbo");

                entity.Property(e => e.BloodGroup).HasMaxLength(300);

                entity.Property(e => e.CategoryIds).HasMaxLength(500);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CommunicableDisease).HasMaxLength(300);

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.FatherContact).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FatherProfession).HasMaxLength(50);

                entity.Property(e => e.FormNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.GuardianContact).HasMaxLength(50);

                entity.Property(e => e.GuardianName).HasMaxLength(100);

                entity.Property(e => e.InSource).HasMaxLength(50);

                entity.Property(e => e.InstitutionLastAttendant).HasMaxLength(300);

                entity.Property(e => e.IsAppearForTest)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.IsGovtEmployee)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.LastEnrolmentNo).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.OnlineFormStepStatus).HasDefaultValueSql("((-1))");

                entity.Property(e => e.OutSource).HasMaxLength(50);

                entity.Property(e => e.PermanentAddress).HasMaxLength(500);

                entity.Property(e => e.PlcNo).HasMaxLength(100);

                entity.Property(e => e.PostalAddress).HasMaxLength(300);

                entity.Property(e => e.PreviouslyEnrolledInOrg).HasMaxLength(10);

                entity.Property(e => e.ProgramIds).HasMaxLength(500);

                entity.Property(e => e.RegistrationNo).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentContact).HasMaxLength(50);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InsStudentAdmission>(entity =>
            {
                entity.ToTable("InsStudentAdmission", "dbo");

                entity.Property(e => e.ExaminationCenterId).HasColumnName("ExaminationCenterID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InsStudentCateogry>(entity =>
            {
                entity.ToTable("InsStudentCateogry", "dbo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<InsStudentDup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InsStudentDup", "dbo");

                entity.Property(e => e.BloodGroup).HasMaxLength(300);

                entity.Property(e => e.CategoryIds).HasMaxLength(500);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.FatherContact).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FatherProfession).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.GuardianContact).HasMaxLength(50);

                entity.Property(e => e.GuardianName).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InstitutionLastAttendant).HasMaxLength(300);

                entity.Property(e => e.IsAppearForTest).HasMaxLength(10);

                entity.Property(e => e.IsGovtEmployee).HasMaxLength(10);

                entity.Property(e => e.LastEnrolmentNo).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.PermanentAddress).HasMaxLength(500);

                entity.Property(e => e.PlcNo).HasMaxLength(100);

                entity.Property(e => e.PostalAddress).HasMaxLength(300);

                entity.Property(e => e.ProgramIds).HasMaxLength(500);

                entity.Property(e => e.RegistrationNo).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentContact).HasMaxLength(50);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InsStudentDupDup>(entity =>
            {
                entity.ToTable("InsStudentDupDup", "dbo");

                entity.Property(e => e.BloodGroup).HasMaxLength(300);

                entity.Property(e => e.CategoryIds).HasMaxLength(500);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.FatherContact).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FatherProfession).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.GuardianContact).HasMaxLength(50);

                entity.Property(e => e.GuardianName).HasMaxLength(100);

                entity.Property(e => e.InstitutionLastAttendant).HasMaxLength(300);

                entity.Property(e => e.IsAppearForTest).HasMaxLength(10);

                entity.Property(e => e.IsGovtEmployee).HasMaxLength(10);

                entity.Property(e => e.LastEnrolmentNo).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.PermanentAddress).HasMaxLength(500);

                entity.Property(e => e.PlcNo).HasMaxLength(100);

                entity.Property(e => e.PostalAddress).HasMaxLength(300);

                entity.Property(e => e.ProgramIds).HasMaxLength(500);

                entity.Property(e => e.RegistrationNo).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentContact).HasMaxLength(50);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InsStudentEmployment>(entity =>
            {
                entity.ToTable("InsStudentEmployments", "dbo");

                entity.Property(e => e.Department).HasMaxLength(500);

                entity.Property(e => e.PeriodFrom).HasColumnType("date");

                entity.Property(e => e.PeriodTo).HasColumnType("date");

                entity.Property(e => e.PostBps)
                    .HasMaxLength(100)
                    .HasColumnName("PostBPS");
            });

            modelBuilder.Entity<InsStudentFeeMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InsStudentFeeMapping", "dbo");

                entity.Property(e => e.AdditionalValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NetValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TermValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsStudentMeritListing>(entity =>
            {
                entity.ToTable("InsStudentMeritListing", "dbo");

                entity.Property(e => e.MarksCaculated).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsStudentQualification>(entity =>
            {
                entity.ToTable("InsStudentQualifications", "dbo");

                entity.Property(e => e.BoardUniversity).HasMaxLength(500);

                entity.Property(e => e.Division).HasMaxLength(50);

                entity.Property(e => e.ObtMarks)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PercentageMarks)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RollNo).HasMaxLength(50);

                entity.Property(e => e.TotalMarks)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InsStudentSubjectMapping>(entity =>
            {
                entity.ToTable("InsStudentSubjectMapping", "dbo");
            });

            modelBuilder.Entity<InsStudentTestScore>(entity =>
            {
                entity.ToTable("InsStudentTestScore", "dbo");

                entity.Property(e => e.ObtainedScore).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RollNo).HasMaxLength(50);

                entity.Property(e => e.TotalScore).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsSubject>(entity =>
            {
                entity.ToTable("InsSubject", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(50);
            });

            modelBuilder.Entity<InsTermAppliedItemsMapping>(entity =>
            {
                entity.ToTable("InsTermAppliedItemsMapping", "dbo");
            });

            modelBuilder.Entity<InvCategory>(entity =>
            {
                entity.ToTable("InvCategory", "dbo");

                entity.Property(e => e.CategoryGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Store')");

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OfferEndDate).HasColumnType("date");

                entity.Property(e => e.OfferStartDate).HasColumnType("date");
            });

            modelBuilder.Entity<InvCompany>(entity =>
            {
                entity.ToTable("InvCompany", "dbo");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InvCustomer>(entity =>
            {
                entity.ToTable("InvCustomer", "dbo");

                entity.Property(e => e.AcctBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AcctMaxBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Address1).HasMaxLength(30);

                entity.Property(e => e.Address2).HasMaxLength(30);

                entity.Property(e => e.Cnicno)
                    .HasMaxLength(100)
                    .HasColumnName("CNICNo");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Company).HasMaxLength(30);

                entity.Property(e => e.Contact1).HasMaxLength(30);

                entity.Property(e => e.Contact2).HasMaxLength(30);

                entity.Property(e => e.DiscPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Gstno)
                    .HasMaxLength(100)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.ImageName).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile).HasMaxLength(15);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ntnno)
                    .HasMaxLength(100)
                    .HasColumnName("NTNNo");

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.Terms).HasMaxLength(15);
            });

            modelBuilder.Entity<InvCustomerType>(entity =>
            {
                entity.ToTable("InvCustomerType", "dbo");

                entity.Property(e => e.DefaultPaymentType).HasMaxLength(20);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderTypeGroup)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('General')");

                entity.Property(e => e.ReceiptFormate).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<InvDeliveryChallanDetail>(entity =>
            {
                entity.ToTable("InvDeliveryChallanDetail", "dbo");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvDeliveryChallanMaster>(entity =>
            {
                entity.ToTable("InvDeliveryChallanMaster", "dbo");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DriverContact).HasMaxLength(50);

                entity.Property(e => e.DriverName).HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.VehicleNo).HasMaxLength(200);
            });

            modelBuilder.Entity<InvDemandNote>(entity =>
            {
                entity.ToTable("InvDemandNote", "dbo");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<InvDemandNoteDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvDemandNoteDetail", "dbo");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvGatePassInDetail>(entity =>
            {
                entity.ToTable("InvGatePassInDetail", "dbo");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvGatePassInMaster>(entity =>
            {
                entity.ToTable("InvGatePassInMaster", "dbo");

                entity.Property(e => e.DriverContact).HasMaxLength(50);

                entity.Property(e => e.DriverName).HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.VehicleNo).HasMaxLength(200);
            });

            modelBuilder.Entity<InvJcMonthSetting>(entity =>
            {
                entity.ToTable("InvJcMonthSetting", "dbo");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.WeekNosInJc).HasMaxLength(50);
            });

            modelBuilder.Entity<InvLocation>(entity =>
            {
                entity.ToTable("InvLocation", "dbo");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InvPackageProductsMapping>(entity =>
            {
                entity.ToTable("InvPackageProductsMapping", "dbo");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvPaymentType>(entity =>
            {
                entity.ToTable("InvPaymentType", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.PaymentType).HasMaxLength(100);

                entity.Property(e => e.TypeGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Other')");
            });

            modelBuilder.Entity<InvProduct>(entity =>
            {
                entity.ToTable("InvProduct", "dbo");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.BillType).HasMaxLength(50);

                entity.Property(e => e.ChargeMeterType).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompDiscPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompExtraDiscPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CostIncTax).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImageName).HasMaxLength(300);

                entity.Property(e => e.MaterialSize)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinimumLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OfferEndDate).HasColumnType("date");

                entity.Property(e => e.OfferRate).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.OfferStartDate).HasColumnType("date");

                entity.Property(e => e.PurchaseUnitId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReorderQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SaleDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaleTaxCalMethodInPur).HasMaxLength(20);

                entity.Property(e => e.SaleUnitId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UnitWeight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvProductBatch>(entity =>
            {
                entity.ToTable("InvProductBatch", "dbo");

                entity.Property(e => e.BatchBarcode).HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(100);

                entity.Property(e => e.Source).HasMaxLength(10);
            });

            modelBuilder.Entity<InvProductLedger>(entity =>
            {
                entity.ToTable("InvProductLedger", "dbo");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BatchBarcode).HasMaxLength(200);

                entity.Property(e => e.BatchNo).HasMaxLength(100);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.QtyCut).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QtyIn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QtyOut).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SourceParty).HasMaxLength(300);
            });

            modelBuilder.Entity<InvProductionDetail>(entity =>
            {
                entity.ToTable("InvProductionDetail", "dbo");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CunsumptionQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductionQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Size)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InvProductionMaster>(entity =>
            {
                entity.ToTable("InvProductionMaster", "dbo");

                entity.Property(e => e.EndTime).HasMaxLength(50);

                entity.Property(e => e.GridMeterUnits).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductionMeterUnits).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductionPerUnitCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StartTime).HasMaxLength(50);

                entity.Property(e => e.TotalMaterial).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalProduction).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalTimeInHours).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalWasteMaterialCost).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvPurchaseDetail>(entity =>
            {
                entity.ToTable("InvPurchaseDetail", "dbo");

                entity.Property(e => e.AdditionalTaxAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BatchNo).HasMaxLength(100);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CutQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Disc).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Scheme).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvPurchaseMaster>(entity =>
            {
                entity.ToTable("InvPurchaseMaster", "dbo");

                entity.Property(e => e.AdvanceTaxAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BiltyDate).HasColumnType("date");

                entity.Property(e => e.BiltyNo).HasMaxLength(50);

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DriverContactNo).HasMaxLength(50);

                entity.Property(e => e.DriverName).HasMaxLength(100);

                entity.Property(e => e.Frieght).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GrandTotalBeforeWhTax).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvoiceDisc).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LoadingCharges).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VehicleNo).HasMaxLength(50);

                entity.Property(e => e.WithholdingTaxInAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WithholdingTaxInPer).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvPurchaseOrderDetail>(entity =>
            {
                entity.ToTable("InvPurchaseOrderDetail", "dbo");

                entity.Property(e => e.QtyDamaged).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.QtyOrdered).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.QtyReceived).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvPurchaseOrderMaster>(entity =>
            {
                entity.ToTable("InvPurchaseOrderMaster", "dbo");

                entity.Property(e => e.Instructions).HasMaxLength(200);

                entity.Property(e => e.OrderingMode).HasMaxLength(50);

                entity.Property(e => e.Potype)
                    .HasMaxLength(50)
                    .HasColumnName("POType");

                entity.Property(e => e.Reference).HasMaxLength(200);

                entity.Property(e => e.ShipTo1).HasMaxLength(55);

                entity.Property(e => e.ShipTo2).HasMaxLength(55);

                entity.Property(e => e.ShipToDestination).HasMaxLength(10);

                entity.Property(e => e.ShipVia).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Terms).HasMaxLength(15);

                entity.Property(e => e.TotalCharges).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCostReceived).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InvQuatationDetail>(entity =>
            {
                entity.ToTable("InvQuatationDetail", "dbo");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvQuatationMaster>(entity =>
            {
                entity.ToTable("InvQuatationMaster", "dbo");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<InvSaleClosing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvSaleClosing", "dbo");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TellAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvSaleClosingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvSaleClosingDetail", "dbo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvSaleDetail>(entity =>
            {
                entity.ToTable("InvSaleDetail", "dbo");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FurtherTax).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Pctcode)
                    .HasMaxLength(100)
                    .HasColumnName("PCTCode");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceExclusiveTax).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TaxCharged).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvSaleMaster>(entity =>
            {
                entity.ToTable("InvSaleMaster", "dbo");

                entity.Property(e => e.BuyerCnic)
                    .HasMaxLength(50)
                    .HasColumnName("BuyerCNIC");

                entity.Property(e => e.BuyerNtn)
                    .HasMaxLength(50)
                    .HasColumnName("BuyerNTN");

                entity.Property(e => e.BuyerPhoneNumber).HasMaxLength(50);

                entity.Property(e => e.CancelledReason).HasMaxLength(300);

                entity.Property(e => e.Change).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerContact).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.DiscountCalculated).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountRemarks).HasMaxLength(200);

                entity.Property(e => e.EmpCreditType).HasMaxLength(50);

                entity.Property(e => e.FbrInvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.FbrPosid).HasColumnName("FbrPOSID");

                entity.Property(e => e.FbrResponse).HasMaxLength(200);

                entity.Property(e => e.FbrResponseCode).HasMaxLength(10);

                entity.Property(e => e.FbrUsin)
                    .HasMaxLength(50)
                    .HasColumnName("FbrUSIN");

                entity.Property(e => e.FurtherTax).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsSentToFbr).HasDefaultValueSql("((-1))");

                entity.Property(e => e.NextServiceDate).HasColumnType("date");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentReceived).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ScaleNumber).HasMaxLength(100);

                entity.Property(e => e.ServiceChargesCalculated).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxCalculated).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalQuantity).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VehicleNo).HasMaxLength(100);
            });

            modelBuilder.Entity<InvSalemanToRoutsMapping>(entity =>
            {
                entity.ToTable("InvSalemanToRoutsMapping", "dbo");
            });

            modelBuilder.Entity<InvSchemeDetail>(entity =>
            {
                entity.ToTable("InvSchemeDetail", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<InvSchemeMaster>(entity =>
            {
                entity.ToTable("InvSchemeMaster", "dbo");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DiscLevel).HasMaxLength(1);

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SchemeOn).HasMaxLength(1);

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InvShift>(entity =>
            {
                entity.ToTable("InvShift", "dbo");

                entity.Property(e => e.Shift).HasMaxLength(100);
            });

            modelBuilder.Entity<InvStockAdjustment>(entity =>
            {
                entity.ToTable("InvStockAdjustment", "dbo");

                entity.Property(e => e.Remarks).HasMaxLength(500);
            });

            modelBuilder.Entity<InvStockAdjustmentDetail>(entity =>
            {
                entity.ToTable("InvStockAdjustmentDetail", "dbo");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PhysicalQty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.QtyDifference).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SystemQty).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvStockTransfer>(entity =>
            {
                entity.ToTable("InvStockTransfer", "dbo");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(500);
            });

            modelBuilder.Entity<InvStockTransferDetail>(entity =>
            {
                entity.ToTable("InvStockTransferDetail", "dbo");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DemandedQty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StockOnHand).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InvThirdPartyCustomer>(entity =>
            {
                entity.ToTable("InvThirdPartyCustomer", "dbo");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InvUnit>(entity =>
            {
                entity.ToTable("InvUnit", "dbo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitOfConversion).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<InvVehicle>(entity =>
            {
                entity.ToTable("InvVehicle", "dbo");

                entity.Property(e => e.FrameNo).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobCard).HasMaxLength(100);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.VehicleBrand)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VehicleName).HasMaxLength(200);

                entity.Property(e => e.VehicleNo).HasMaxLength(50);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(100);
            });

            modelBuilder.Entity<InvVendor>(entity =>
            {
                entity.ToTable("InvVendor", "dbo");

                entity.Property(e => e.Address1).HasMaxLength(500);

                entity.Property(e => e.Address2).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Company).HasMaxLength(500);

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.DefaultBillableDepartment).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinimumOrder).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NtnNo).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.SaleTaxNumber).HasMaxLength(200);

                entity.Property(e => e.TaxType).HasMaxLength(20);

                entity.Property(e => e.VendordTerms).HasMaxLength(15);

                entity.Property(e => e.Website).HasColumnType("ntext");

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<InvWarehouse>(entity =>
            {
                entity.ToTable("InvWarehouse", "dbo");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.StoreType).HasMaxLength(20);
            });

            modelBuilder.Entity<OrgBranch>(entity =>
            {
                entity.ToTable("OrgBranch", "dbo");

                entity.Property(e => e.AccAccountMethod).HasMaxLength(20);

                entity.Property(e => e.AccAccountPeriod).HasMaxLength(20);

                entity.Property(e => e.AccBussinessType).HasMaxLength(20);

                entity.Property(e => e.AccPostingMethod).HasMaxLength(20);

                entity.Property(e => e.AccVoucherAutoApproved)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.BranchLogo).HasMaxLength(200);

                entity.Property(e => e.BranchLogoName).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.InsFeeAccInteg)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.InvBillAmountLimitForScharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InvBillAmountLimitForSCharges");

                entity.Property(e => e.InvCreateJvInCaseOfQtsale)
                    .HasMaxLength(3)
                    .HasColumnName("InvCreateJvInCaseOfQTSale");

                entity.Property(e => e.InvDefaultPaymentType).HasMaxLength(50);

                entity.Property(e => e.InvIsItemComboLoadOnStart)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InvIsSchargesFlatPos).HasColumnName("InvIsSChargesFlatPos");

                entity.Property(e => e.InvItemCodeReadOnly).HasMaxLength(10);

                entity.Property(e => e.InvMixSaleQtyCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.InvProductLedgerTransactionFromJv).HasMaxLength(10);

                entity.Property(e => e.InvPurchaseAccInteg)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.InvRowAddingStyle)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Append')");

                entity.Property(e => e.InvSaleAccInteg)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.InvSaleInvoiceDate)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.InvSchargesInPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InvSChargesInPercent");

                entity.Property(e => e.InvSkipSchargesIfBillIsQt)
                    .HasMaxLength(10)
                    .HasColumnName("InvSkipSChargesIfBillIsQT");

                entity.Property(e => e.InvTaxInPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvUpdateLastPrices).HasMaxLength(5);

                entity.Property(e => e.InvUseFbrApi).HasMaxLength(1);

                entity.Property(e => e.InventoryType).HasMaxLength(30);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LongAddress).HasMaxLength(500);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.NtnNo).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ReportsTitle).HasMaxLength(200);

                entity.Property(e => e.ResBillAmountLimitForScharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ResBillAmountLimitForSCharges");

                entity.Property(e => e.ResDefaultBillTypeInPayment)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('Takeaway')");

                entity.Property(e => e.ResIsItemAddtoSeparateLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResIsPrintKotPlaceOrder)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ResIsShowIconicSearch)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ResIsTableSelection)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ResPrintOptionFromPos)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'KOT')");

                entity.Property(e => e.ResSchargesInPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ResSChargesInPercent");

                entity.Property(e => e.ResTaxInPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShortAddress).HasMaxLength(100);

                entity.Property(e => e.Strn)
                    .HasMaxLength(50)
                    .HasColumnName("STRN");

                entity.Property(e => e.TaxFormation).HasMaxLength(100);

                entity.Property(e => e.UseDataInMerging).HasMaxLength(3);

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<OrgFeaturesMapping>(entity =>
            {
                entity.ToTable("OrgFeaturesMapping", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<OrgOrgSystemsMapping>(entity =>
            {
                entity.ToTable("OrgOrgSystemsMapping", "dbo");

                entity.Property(e => e.SystemLabelDesc).HasMaxLength(300);
            });

            modelBuilder.Entity<OrgOrganization>(entity =>
            {
                entity.ToTable("OrgOrganization", "dbo");

                entity.Property(e => e.AccountIntegration)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.BankAccountNo).HasMaxLength(200);

                entity.Property(e => e.BankLogo).HasMaxLength(100);

                entity.Property(e => e.DmAccFyear)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("DmAccFYear")
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmAccGroup)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmAccHead)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmAccMapping)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmAccType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmAccounts)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmBatch)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmCompany)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmCustomer)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmDinTable)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmEmployee)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmExamination)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmFeeGroup)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmFeeItem)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmFeeTerm)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmFnsdCategory)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmFnsdFood)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmFnsdFoodAvailablity).HasMaxLength(10);

                entity.Property(e => e.DmGenCity)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmGenDomicile)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmHrmCategory)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmHrmDepartment)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmHrmDesignation)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmInsDiscipline)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Merge')");

                entity.Property(e => e.DmInstitute)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmInvCustType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmInvPayType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmInvShift)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmLocation)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmPatients)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmProduct)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmProductCategory)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmProgram)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmQualification)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmReligion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmResShift)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmSession)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmStudentCatgory)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmSubject)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmThirdPartyCompany)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmUnit)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmVehicle)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmVendor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmWard)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.DmWarehouse)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Separate')");

                entity.Property(e => e.Edate).HasColumnName("EDate");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FbrApiProduction).HasMaxLength(100);

                entity.Property(e => e.FbrApiSandBox).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOnlineFormSaveInSections).HasMaxLength(10);

                entity.Property(e => e.IsRequiredLoginForOnlineAdmin).HasMaxLength(10);

                entity.Property(e => e.IsShowBankReceiptInPrint).HasMaxLength(10);

                entity.Property(e => e.IsShowPayProChallanNoOnBankRecipt).HasMaxLength(10);

                entity.Property(e => e.IsShowSingleReceiptInPrint).HasMaxLength(10);

                entity.Property(e => e.IsShowUndertakenInPrint).HasMaxLength(10);

                entity.Property(e => e.IsSkipFromGoverHouse)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsStudentPhotoMandatory).HasMaxLength(10);

                entity.Property(e => e.KpraKey).HasMaxLength(100);

                entity.Property(e => e.KpraNo).HasMaxLength(100);

                entity.Property(e => e.LongAddress).HasMaxLength(500);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.OrgCode).HasMaxLength(4);

                entity.Property(e => e.OrgLogo).HasMaxLength(100);

                entity.Property(e => e.OrgName).HasMaxLength(200);

                entity.Property(e => e.OrgShortName).HasMaxLength(100);

                entity.Property(e => e.PayProCharges).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayProCode).HasMaxLength(4);

                entity.Property(e => e.PaymentMode).HasMaxLength(10);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ReportsTitle).HasMaxLength(200);

                entity.Property(e => e.ShortAddress).HasMaxLength(100);

                entity.Property(e => e.SmsApiKey).HasMaxLength(100);

                entity.Property(e => e.SmsApiSender).HasMaxLength(100);

                entity.Property(e => e.SmsApiUrl).HasMaxLength(100);

                entity.Property(e => e.TechnicalSupportContactNo).HasMaxLength(50);

                entity.Property(e => e.UseInfoForAllBranches)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<PyAdvanceLoanInfo>(entity =>
            {
                entity.ToTable("PyAdvanceLoanInfo", "dbo");

                entity.Property(e => e.AdvanceMonthYearDay).HasColumnType("date");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.EmployeePayrollType).HasMaxLength(50);

                entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenLoanPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<PyAllowanceMaster>(entity =>
            {
                entity.ToTable("PyAllowanceMaster", "dbo");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Value).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<PyBasicPayDetail>(entity =>
            {
                entity.ToTable("PyBasicPayDetail", "dbo");

                entity.Property(e => e.Increment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Max).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Min).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pbs).HasColumnName("PBS");
            });

            modelBuilder.Entity<PyBasicPayMaster>(entity =>
            {
                entity.ToTable("PyBasicPayMaster", "dbo");
            });

            modelBuilder.Entity<PyConveyanceAllowance>(entity =>
            {
                entity.ToTable("PyConveyanceAllowance", "dbo");

                entity.Property(e => e.FromBps).HasColumnName("FromBPS");

                entity.Property(e => e.IsFlat)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToBps).HasColumnName("ToBPS");
            });

            modelBuilder.Entity<PyCorporateAllowanceMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PyCorporateAllowanceMapping", "dbo");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PyCorporateSalaryMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PyCorporateSalaryMaster", "dbo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Salary).HasColumnType("decimal(16, 4)");
            });

            modelBuilder.Entity<PyCpFundCalculation>(entity =>
            {
                entity.ToTable("PyCpFundCalculation", "dbo");

                entity.Property(e => e.Bps).HasColumnName("BPS");

                entity.Property(e => e.CalculatedRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaximumAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinimumAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PercentRateOnMean).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PyDeductionMaster>(entity =>
            {
                entity.ToTable("PyDeductionMaster", "dbo");

                entity.Property(e => e.Amount).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PyEmployeeDeductionMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PyEmployeeDeductionMapping", "dbo");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<PyEmployeeDeductionMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PyEmployeeDeductionMaster", "dbo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PyEmployeeSalaryAllowanceMapping>(entity =>
            {
                entity.ToTable("PyEmployeeSalaryAllowanceMapping", "dbo");

                entity.Property(e => e.GrossAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<PyEmployeeSalaryMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PyEmployeeSalaryMaster", "dbo");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PyEmployeeTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PyEmployeeTransaction", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayrollType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'M')");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.Vno)
                    .IsUnicode(false)
                    .HasColumnName("VNo");
            });

            modelBuilder.Entity<PyFormula>(entity =>
            {
                entity.ToTable("PyFormula", "dbo");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FormulaCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.FormulaSection)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PyHouseRentAllowanceSetting>(entity =>
            {
                entity.ToTable("PyHouseRentAllowanceSetting", "dbo");

                entity.Property(e => e.Bps).HasColumnName("BPS");

                entity.Property(e => e.Min).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PyPaymentSlip>(entity =>
            {
                entity.ToTable("PyPaymentSlip", "dbo");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentMonthYearDay).HasColumnType("date");

                entity.Property(e => e.PaymentToDate).HasColumnType("date");

                entity.Property(e => e.PayrollType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'M')");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.SlipNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PyPayrollGeneration>(entity =>
            {
                entity.ToTable("PyPayrollGeneration", "dbo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PyPayrollGenerationDetail>(entity =>
            {
                entity.ToTable("PyPayrollGenerationDetail", "dbo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PyPayrollGenerationMaster>(entity =>
            {
                entity.ToTable("PyPayrollGenerationMaster", "dbo");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.PayrollTotalValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayrollType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasColumnName("VNo")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PySalaryHead>(entity =>
            {
                entity.ToTable("PySalaryHead", "dbo");

                entity.Property(e => e.Operation)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PyStaffAttendance>(entity =>
            {
                entity.ToTable("PyStaffAttendance", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PyTaxDeductionPattern>(entity =>
            {
                entity.ToTable("PyTaxDeductionPattern", "dbo");

                entity.Property(e => e.FixedTaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncomeTaxRatePer).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LowerLimit).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UpperLimit).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<ResBed>(entity =>
            {
                entity.ToTable("ResBed", "dbo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<ResCurrencyNote>(entity =>
            {
                entity.ToTable("ResCurrencyNote", "dbo");
            });

            modelBuilder.Entity<ResCustomerTypeItemsMapping>(entity =>
            {
                entity.ToTable("ResCustomerTypeItemsMapping", "dbo");
            });

            modelBuilder.Entity<ResFood>(entity =>
            {
                entity.ToTable("ResFood", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CookingTimeHours).HasMaxLength(10);

                entity.Property(e => e.CookingTimeMin).HasMaxLength(10);

                entity.Property(e => e.ImageName).HasMaxLength(300);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSpecial).HasDefaultValueSql("((0))");

                entity.Property(e => e.KitchenId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OfferEndDate).HasColumnType("date");

                entity.Property(e => e.OfferRate).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.OfferStartDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'Standard')");

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ResFoodAddon>(entity =>
            {
                entity.ToTable("ResFoodAddons", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ResFoodAvailability>(entity =>
            {
                entity.ToTable("ResFoodAvailability", "dbo");

                entity.Property(e => e.AvailableDays).HasMaxLength(500);

                entity.Property(e => e.FoodIds).HasMaxLength(500);

                entity.Property(e => e.FromTime).HasMaxLength(50);

                entity.Property(e => e.ToTime).HasMaxLength(50);
            });

            modelBuilder.Entity<ResFoodCategory>(entity =>
            {
                entity.ToTable("ResFoodCategory", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ImageName).HasMaxLength(300);

                entity.Property(e => e.IsOffer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OfferEndDate).HasColumnType("date");

                entity.Property(e => e.OfferStartDate).HasColumnType("date");

                entity.Property(e => e.ParentCategoryId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ResFoodToAddonsMapping>(entity =>
            {
                entity.ToTable("ResFoodToAddonsMapping", "dbo");
            });

            modelBuilder.Entity<ResFoodVariant>(entity =>
            {
                entity.ToTable("ResFoodVariant", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSalePriceOpen)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Variant)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ResFoodVariantRecipe>(entity =>
            {
                entity.ToTable("ResFoodVariantRecipe", "dbo");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<ResKipraHistory>(entity =>
            {
                entity.ToTable("ResKipraHistory", "dbo");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KipraKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ntn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NTN");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ResKitchen>(entity =>
            {
                entity.ToTable("ResKitchen", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<ResOrderType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ResOrderType", "dbo");

                entity.Property(e => e.CreditType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('None')");

                entity.Property(e => e.DefaultPaymentType).HasMaxLength(20);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderTypeGroup).HasMaxLength(50);

                entity.Property(e => e.ReceiptFormate).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ResPackageVarientsMapping>(entity =>
            {
                entity.ToTable("ResPackageVarientsMapping", "dbo");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ResPatient>(entity =>
            {
                entity.ToTable("ResPatient", "dbo");

                entity.Property(e => e.BedId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientMrNo).HasMaxLength(50);

                entity.Property(e => e.PatientName).HasMaxLength(100);
            });

            modelBuilder.Entity<ResSaleClosing>(entity =>
            {
                entity.ToTable("ResSaleClosing", "dbo");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TellAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ResSaleClosingDetail>(entity =>
            {
                entity.ToTable("ResSaleClosingDetail", "dbo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentType).HasMaxLength(20);
            });

            modelBuilder.Entity<ResSaleDetail>(entity =>
            {
                entity.ToTable("ResSaleDetail", "dbo");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ResSaleDetailTemp>(entity =>
            {
                entity.ToTable("ResSaleDetailTemp", "dbo");

                entity.Property(e => e.Flage)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ResSaleMaster>(entity =>
            {
                entity.ToTable("ResSaleMaster", "dbo");

                entity.Property(e => e.ApprovedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BedId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelledReason).HasMaxLength(300);

                entity.Property(e => e.Change).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CookingTimeHours).HasMaxLength(10);

                entity.Property(e => e.CookingTimeMin).HasMaxLength(10);

                entity.Property(e => e.CustomerContact).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.DiscountCalculated).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountRemarks).HasMaxLength(200);

                entity.Property(e => e.EmpCreditType).HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentReceived).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentType).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ServiceChargesCalculated).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusFromKitchen)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'No Response')");

                entity.Property(e => e.StudentNo).HasMaxLength(50);

                entity.Property(e => e.TaxCalculated).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WaiterId).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<ResShift>(entity =>
            {
                entity.ToTable("ResShift", "dbo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Shift).HasMaxLength(100);
            });

            modelBuilder.Entity<ResTable>(entity =>
            {
                entity.ToTable("ResTable", "dbo");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ImagePath).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<ResVarientPricingByCustType>(entity =>
            {
                entity.ToTable("ResVarientPricingByCustType", "dbo");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ResWard>(entity =>
            {
                entity.ToTable("ResWard", "dbo");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<SysControllesGroup>(entity =>
            {
                entity.ToTable("SysControllesGroup", "dbo");

                entity.Property(e => e.ActionLink).HasMaxLength(100);

                entity.Property(e => e.ControllGroupName).HasMaxLength(50);

                entity.Property(e => e.ControllerLink).HasMaxLength(100);

                entity.Property(e => e.Controlls).HasMaxLength(300);
            });

            modelBuilder.Entity<SysErpDefaultSetting>(entity =>
            {
                entity.ToTable("SysErpDefaultSetting", "dbo");

                entity.Property(e => e.IsUseMemoryCashe)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'N')");

                entity.Property(e => e.SoftwareMode).HasMaxLength(10);
            });

            modelBuilder.Entity<SysExecptionLogging>(entity =>
            {
                entity.ToTable("SysExecptionLogging", "dbo");

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.Controller).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnName("date");
            });

            modelBuilder.Entity<SysFeature>(entity =>
            {
                entity.ToTable("SysFeature", "dbo");

                entity.Property(e => e.Details).HasMaxLength(500);

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Feature).HasMaxLength(50);
            });

            modelBuilder.Entity<SysForm>(entity =>
            {
                entity.ToTable("SysForm", "dbo");

                entity.Property(e => e.FormName).HasMaxLength(100);

                entity.Property(e => e.FrmAction).HasMaxLength(100);

                entity.Property(e => e.FrmController).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysHtml>(entity =>
            {
                entity.ToTable("SysHtml", "dbo");

                entity.Property(e => e.Section).HasMaxLength(100);
            });

            modelBuilder.Entity<SysInvTypeWiseControll>(entity =>
            {
                entity.ToTable("SysInvTypeWiseControll", "dbo");

                entity.Property(e => e.InventoryType).HasMaxLength(50);
            });

            modelBuilder.Entity<SysLableContent>(entity =>
            {
                entity.ToTable("SysLableContent", "dbo");

                entity.Property(e => e.LableContentStr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Language).HasMaxLength(50);
            });

            modelBuilder.Entity<SysLayout>(entity =>
            {
                entity.ToTable("SysLayout", "dbo");

                entity.Property(e => e.LayoutName).HasMaxLength(100);

                entity.Property(e => e.LayoutPath).HasMaxLength(500);
            });

            modelBuilder.Entity<SysModule>(entity =>
            {
                entity.ToTable("SysModule", "dbo");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Module).HasMaxLength(100);
            });

            modelBuilder.Entity<SysModuleFormsMapping>(entity =>
            {
                entity.ToTable("SysModuleFormsMapping", "dbo");
            });

            modelBuilder.Entity<SysMonthName>(entity =>
            {
                entity.ToTable("SysMonthName", "dbo");

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysOrgFormsMapping>(entity =>
            {
                entity.ToTable("SysOrgFormsMapping", "dbo");

                entity.Property(e => e.FormLabelDesc).HasMaxLength(200);

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysOrgModulesMapping>(entity =>
            {
                entity.ToTable("SysOrgModulesMapping", "dbo");

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleLabelDesc).HasMaxLength(200);
            });

            modelBuilder.Entity<SysSystem>(entity =>
            {
                entity.ToTable("SysSystem", "dbo");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.Icon2).HasMaxLength(500);

                entity.Property(e => e.SysAction).HasMaxLength(100);

                entity.Property(e => e.SysController).HasMaxLength(100);

                entity.Property(e => e.SystemName).HasMaxLength(100);

                entity.Property(e => e.UserAuthGroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<SysWeekDay>(entity =>
            {
                entity.ToTable("SysWeekDay", "dbo");

                entity.Property(e => e.Day).HasMaxLength(50);
            });

            modelBuilder.Entity<SysYear>(entity =>
            {
                entity.ToTable("SysYear", "dbo");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1", "dbo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Table2ItemList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_2_item_list", "dbo");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .HasColumnName("description");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .HasColumnName("item_code");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchase_price");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sale_price");
            });

            modelBuilder.Entity<Table2Stock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_2_stock", "dbo");

                entity.Property(e => e.CategorKey)
                    .HasMaxLength(50)
                    .HasColumnName("categor_key");

                entity.Property(e => e.Category)
                    .HasMaxLength(500)
                    .HasColumnName("category");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .HasColumnName("descr");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(100)
                    .HasColumnName("itemcode");

                entity.Property(e => e.Prate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("prate");

                entity.Property(e => e.Srate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("srate");
            });

            modelBuilder.Entity<TableBakemanCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_bakeman_category", "dbo");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .HasColumnName("category");
            });

            modelBuilder.Entity<TableMughalCarProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_mughal_car_products", "dbo");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("cost");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("sale_price");
            });

            modelBuilder.Entity<TempInsStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempInsStudent", "dbo");

                entity.Property(e => e.BloodGroup).HasMaxLength(300);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.FatherContact).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FatherProfession).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.GuardianContact).HasMaxLength(50);

                entity.Property(e => e.GuardianName).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.PermanentAddress).HasMaxLength(500);

                entity.Property(e => e.PlcNo).HasMaxLength(100);

                entity.Property(e => e.PostalAddress).HasMaxLength(300);

                entity.Property(e => e.RegistrationNo).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentContact).HasMaxLength(50);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UsrSystemUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UsrSystemUser", "dbo");

                entity.Property(e => e.AuthorizationType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.DefBatchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefClassId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefDateOfJoning)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefDob)
                    .HasColumnType("date")
                    .HasColumnName("DefDOB")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefGender)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'Male')");

                entity.Property(e => e.DefInstitutionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefJoiningSessionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefNationality)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Pakistani')");

                entity.Property(e => e.DefQualificationId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefReligionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefSessionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvIsOpenTellLimitOpening)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAllowForDiscount)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginName).IsRequired();

                entity.Property(e => e.LoginType).HasMaxLength(20);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserRole).HasMaxLength(50);

                entity.Property(e => e.UserType).HasMaxLength(20);
            });

            modelBuilder.Entity<UsrUserBranchesMapping>(entity =>
            {
                entity.ToTable("UsrUserBranchesMapping", "dbo");
            });

            modelBuilder.Entity<UsrUserFormsMapping>(entity =>
            {
                entity.ToTable("UsrUserFormsMapping", "dbo");

                entity.Property(e => e.CanApprove).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanCreate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanView).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UsrUserParmsMapping>(entity =>
            {
                entity.ToTable("UsrUserParmsMapping", "dbo");

                entity.Property(e => e.ParmType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
