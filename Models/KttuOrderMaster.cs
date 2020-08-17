using System;
using System.Collections.Generic;

namespace DotNetCodeAPI.Models
{
    public partial class KttuOrderMaster
    {
        public string ObjId { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int OrderNo { get; set; }
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string OrderType { get; set; }
        public string Remarks { get; set; }
        public DateTime OrderDate { get; set; }
        public string OperatorCode { get; set; }
        public string SalCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderRateType { get; set; }
        public string GsCode { get; set; }
        public decimal Rate { get; set; }
        public decimal? AdvanceOrdAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public string ObjectStatus { get; set; }
        public int BillNo { get; set; }
        public string Cflag { get; set; }
        public string CancelledBy { get; set; }
        public string BillCounter { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string ClosedBranch { get; set; }
        public string ClosedFlag { get; set; }
        public string ClosedBy { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string Karat { get; set; }
        public decimal? OrderDayRate { get; set; }
        public string NewBillNo { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? TotalAmountBeforeTax { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public int? ShiftId { get; set; }
        public string IsPan { get; set; }
        public int? OldOrderNo { get; set; }
        public Guid UniqRowId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string MobileNo { get; set; }
        public string State { get; set; }
        public int? StateCode { get; set; }
        public string Tin { get; set; }
        public string PanNo { get; set; }
        public int? EstNo { get; set; }
        public string IdType { get; set; }
        public string IdDetails { get; set; }
        public string BookingType { get; set; }
        public string Salutation { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string ManagerCode { get; set; }
        public string IsLock { get; set; }
        public decimal? AdditionalAmount { get; set; }
        public string OrderReferenceNo { get; set; }
        public int? OrderSource { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string OrderAdvanceRateType { get; set; }
        public DateTime? RateFixedTill { get; set; }
        public string CustomerType { get; set; }
        public int? CentralRefNo { get; set; }
        public decimal? AdvPercent { get; set; }
    }
}
