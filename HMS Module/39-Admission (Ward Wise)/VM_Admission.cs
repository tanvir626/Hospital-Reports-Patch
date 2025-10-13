using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class VM_Admission
    {

        /// <summary>
        /// START TOKEN INFORMATION
        /// </summary>
        public string TokenNo { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<int> DepartmentId { get; set; }

        public Nullable<int> DiagnosisID { get; set; }
        public string DeptName { get; set; }
        public int TotalAdmittedPatient { get; set; }
        public int TotalDischargedPatient { get; set; }
        public int LastAdmissionQty { get; set; }
        public int CurrentAdmissionQty { get; set; }

        public Nullable<int> RfdDept { get; set; }
        public Nullable<int> DrVisitNo { get; set; }
        public Nullable<int> MinorGroupID { get; set; }
        public Nullable<int> DoseID { get; set; }
        public Nullable<int> FrequencyID { get; set; }


        /// <summary>
        /// START ADMISSION INFORMATION INFORMATION
        /// </summary>
        public string AdmissionID { get; set; }
        public int? SpecialityID { get; set; }
        public string PatientID { get; set; }
        public Nullable<System.DateTime> AdmitDate { get; set; }
        public Nullable<System.DateTime> AdmitDateTime { get; set; }
        public string OP_PrescriptionNo { get; set; }
        public string BedID { get; set; }
        public string BillingType { get; set; }
        public string CONS_DOC_ID { get; set; }
        public string ATTN_DOC_ID { get; set; }
        public string Ref_DOC_ID { get; set; }
        public string KIN_Name { get; set; }
        public string KIN_Address { get; set; }
        public string KIN_ContactNo { get; set; }
        public string IsPackage { get; set; }
        public string IsDischarged { get; set; }
        public string ProjectID { get; set; }
        public string ProjectName { get; set; }
        public decimal? AdmissionCharge { get; set; }
        public Nullable<System.DateTime> DischargeDate { get; set; }
        public Nullable<System.TimeSpan> DischargeTime { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string Status { get; set; }
        public string CreateUserID { get; set; }
        public string UserFullName { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public string EditUserID { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }

        public string CONS_DOC_Name { get; set; }
        public string ATTN_DOC_Name { get; set; }
        public string Ref_DOC_Name { get; set; }

        /// <summary>
        /// START PATIENT INFORMATION
        /// </summary>
        public string PatientName { get; set; }
        public string AdmittedPatientInfo { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public Nullable<System.DateTime> Patient_DOB { get; set; }
        public string Patient_Age { get; set; }
        public string Patient_Gender { get; set; }
        public string Patient_ContactNo { get; set; }
        public string Patient_Email { get; set; }
        public string Perm_Address { get; set; }
        public string GurdianName { get; set; }
        public string ChildPID { get; set; }
        public string ChildCID { get; set; }
        public string Gurdian_ContactNo { get; set; }
        public Nullable<long> Pres_VillageID { get; set; }
        public Nullable<long> PresUnionID { get; set; }
        public Nullable<long> Pres_UpazilaID { get; set; }
        public Nullable<long> Pres_DistrictID { get; set; }
        public string Pres_Address { get; set; }

        /// <summary>
        /// START DEPARTMENT INFORMATION
        /// </summary>
        public string RefDepartment { get; set; }
        public string AdmittedDept { get; set; }

        /// <summary>
        /// START TREATMENT INFORMATION
        /// </summary>
        public Nullable<System.DateTime> VisitDate { get; set; }
        public Nullable<System.TimeSpan> VisitTime { get; set; }

        /// <summary>
        /// START BED INFORMATION
        /// </summary>
        public string BedType { get; set; }
        public string WardCabinID { get; set; }
        public string BedName { get; set; }
        public Nullable<decimal> BedCharge { get; set; }
        public string Description { get; set; }
        public string IsFree { get; set; }
        public string IsTempBed { get; set; }
        public Nullable<System.DateTime> OpeningDate { get; set; }
        public Nullable<System.DateTime> ClosingDate { get; set; }

        /// <summary>
        /// START WARD/CABIN INFORMATION
        /// </summary>
        public string CategoryName { get; set; }
        public string WardCabinName { get; set; }
        public string WardBedName { get; set; }

        /// <summary>
        /// START SPECIALLITY INFORMATION
        /// </summary>
        public string SpecialityTitle { get; set; }


        /// START SPECIALLITY INFORMATION
        /// </summary>
        public string CompaintDetails { get; set; }
        public Nullable<System.DateTime> CompaintDate { get; set; }
        public string SymptomTitle { get; set; }

        /// <summary>
        /// START COMPANY INFORMATION
        /// </summary>

        public string CompanyName { get; set; }
        public string BusinessType { get; set; }
        public string Company_BIN { get; set; }
        public string Comapnay_LicenseNo { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPerson_Designation { get; set; }
        public string ContactPerson_ContactNo { get; set; }
        public string Company_Phone { get; set; }
        public string Company_Mobile { get; set; }
        public string Company_Address { get; set; }
        public string Company_Email { get; set; }
        public string Company_Website { get; set; }
        public byte[] Company_Logo { get; set; }

        //// START SYMPTOM INFORMATION
        public Nullable<int> SymptomID { get; set; }
        public string SymptomName { get; set; }

        /// START PHYSICAL EXAMINATION
        public long IP_PEID { get; set; }
        public string PhysicalExamDetails { get; set; }
        public Nullable<System.DateTime> PhysicalExamDate { get; set; }

        /// START DOCTOR
        public string DOC_ID { get; set; }
        public string DOC_NAME { get; set; }

        /// START ITEMS
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string IP_MedReqMasterID { get; set; }

        /// START SERVICES
        public long ServiceID { get; set; }
        public string ServiceName { get; set; }

        /// START TIME SLOTS
        public string TimeSlotName { get; set; }
        public Nullable<int> TimeSlotOrder { get; set; }
        public string rowNum { get; set; }
        public string admission_Date { get; set; }
        public string discharge_Date { get; set; }

        //public string Discharge_Diagnosis { get; set; }
        //public string DischargeType { get; set; }
        //public string ReferredTo { get; set; }
        //public string Discharge_Reason { get; set; }

        public int TotalMale { get; set; }
        public int TotalFemale { get; set; }
    }
}
