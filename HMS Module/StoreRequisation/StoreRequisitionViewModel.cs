using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.ViewModel.INV
{
    public class StoreRequisitionViewModel
    {
        public string StoreReqMasterNo { get; set; }
        //public long StoreReqMasterID { get; set; }
        public DateTime? RequestDate { get; set; }

        public int? ToStoreID { get; set; }
        public string StoreName { get; set; }
        public string SubStoreType { get; set; }
        public string Description { get; set; }
        public string UserFullName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string HR_DeptName { get; set; }
        public string PreviousIndent { get; set; }

        public long StoreReqDetailsID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemUnitName { get; set; }
        public string GenericName { get; set; }
        public double Quantity { get; set; }
        public string ApprovalStatus { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string CompanyName { get; set; }
        public string Company_Mobile { get; set; }
        public string Company_Address { get; set; }
        public string Company_Website { get; set; }
        public string Company_Email { get; set; }
        public byte[] Company_Logo { get; set; }
        public string IndentInfo { get; set; }
        public int StoreTypeID { get; set; }
        public string StoreType { get; set; }

        public double StockInHand { get; set; }

        public string OTReqStatus { get; set; }
        public double? ApprovedQty { get; set; }

        public string RoomNo { get; set; }
    }


}