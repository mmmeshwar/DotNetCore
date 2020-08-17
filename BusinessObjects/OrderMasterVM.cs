using System;
using System.Collections.Generic;

namespace DotNetCodeAPI.BusinessObjects
{
    public class OrderMasterVM
    {
        public string ObjID { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int OrderNo { get; set; }
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string OrderType { get; set; }
        public string Remarks { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string OperatorCode { get; set; }
        public string SalCode { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public string OrderRateType { get; set; }
        public string gsCode { get; set; }
        public decimal Rate { get; set; }
        public Nullable<decimal> AdvacnceOrderAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public string ObjectStatus { get; set; }
        public int BillNo { get; set; }
        public string CFlag { get; set; }
        public string CancelledBy { get; set; }
        public string BillCounter { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string ClosedBranch { get; set; }
        public string ClosedFlag { get; set; }
        public string ClosedBy { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public string Karat { get; set; }
        public Nullable<decimal> OrderDayRate { get; set; }
        public string NewBillNo { get; set; }
        public Nullable<decimal> TaxPercentage { get; set; }
        public Nullable<decimal> TotalAmountBeforeTax { get; set; }
        public Nullable<decimal> TotalTaxAmount { get; set; }
        public Nullable<int> ShiftID { get; set; }
        public string IsPAN { get; set; }
        public Nullable<int> OldOrderNo { get; set; }
        public System.Guid UniqRowID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string MobileNo { get; set; }
        public string State { get; set; }
        public Nullable<int> StateCode { get; set; }
        public string TIN { get; set; }
        public string PANNo { get; set; }
        public Nullable<int> ESTNo { get; set; }
        public string IDType { get; set; }
        public string IDDetails { get; set; }
        public string BookingType { get; set; }
        public string PhoneNo { get; set; }
        public string EmailID { get; set; }
        public string Salutation { get; set; }
        public string ManagerCode { get; set; }
        public List<OrderItemDetailsVM> lstOfOrderItemDetailsVM { get; set; }
        public List<PaymentVM> lstOfPayment { get; set; }
    }

    public class OrderItemDetailsVM
    {
        public string ObjID { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int OrderNo { get; set; }
        public int SlNo { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal FromGrossWt { get; set; }
        public decimal ToGrossWt { get; set; }
        public decimal MCPer { get; set; }
        public decimal WastagePercent { get; set; }
        public decimal Amount { get; set; }
        public string SFlag { get; set; }
        public string SParty { get; set; }
        public int BillNo { get; set; }
        public string ImgID { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public decimal VAPercent { get; set; }
        public decimal ItemAmount { get; set; }
        public string GSCode { get; set; }
        public Nullable<int> FinYear { get; set; }
        public Nullable<decimal> ItemwiseTaxPercentage { get; set; }
        public Nullable<decimal> ItemwiseTaxAmount { get; set; }
        public Nullable<decimal> MCPerPiece { get; set; }
        public string ProductID { get; set; }
        public string IsIssued { get; set; }
        public string CounterCode { get; set; }
        public string SalCode { get; set; }
        public Nullable<decimal> MCPercent { get; set; }
        public Nullable<int> MCType { get; set; }
        public System.Guid UniqRowID { get; set; }
        public Nullable<int> EstNo { get; set; }
        public string ItemType { get; set; }
        public Nullable<decimal> AppSwt { get; set; }
    }

    public class PaymentVM
    {
        public string ObjID { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int SeriesNo { get; set; }
        public int ReceiptNo { get; set; }
        public int SNo { get; set; }
        public string TransType { get; set; }
        public string PayMode { get; set; }
        public string PayDetails { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<decimal> PayAmount { get; set; }
        public string RefBillNo { get; set; }
        public string PartyCode { get; set; }
        public string BillCounter { get; set; }
        public string IsPaid { get; set; }
        public string Bank { get; set; }
        public string BankName { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string CardType { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string CFlag { get; set; }
        public string CardAppNo { get; set; }
        public string SchemeCode { get; set; }
        public string SalBillType { get; set; }
        public string OperatorCode { get; set; }
        public Nullable<int> SessionNo { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string GroupCode { get; set; }
        public Nullable<decimal> AmtReceived { get; set; }
        public Nullable<decimal> BonusAmt { get; set; }
        public Nullable<decimal> WinAmt { get; set; }
        public string CTBranch { get; set; }
        public Nullable<int> FinYear { get; set; }
        public Nullable<decimal> CardCharges { get; set; }
        public string ChequeNo { get; set; }
        public string NewBillNo { get; set; }
        public Nullable<decimal> AddDisc { get; set; }
        public string IsOrderManual { get; set; }
        public Nullable<decimal> CurrencyValue { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public string CurrencyType { get; set; }
        public Nullable<decimal> TaxPercentage { get; set; }
        public string CancelledBy { get; set; }
        public string CancelledRemarks { get; set; }
        public string CancelledDate { get; set; }
        public string IsExchange { get; set; }
        public Nullable<int> ExchangeNo { get; set; }
        public string NewReceiptNo { get; set; }
        public Nullable<decimal> GiftAmount { get; set; }
        public string CardSwipedBy { get; set; }
        public Nullable<int> Version { get; set; }
        public string GSTGroupCode { get; set; }
        public Nullable<decimal> SGSTPercent { get; set; }
        public Nullable<decimal> CGSTPercent { get; set; }
        public Nullable<decimal> IGSTPercent { get; set; }
        public string HSN { get; set; }
        public Nullable<decimal> SGSTAmount { get; set; }
        public Nullable<decimal> CGSTAmount { get; set; }
        public Nullable<decimal> IGSTAmount { get; set; }
        public Nullable<decimal> PayAmountBeforeTax { get; set; }
        public Nullable<decimal> PayTaxAmount { get; set; }
        public string IsCashMarking { get; set; }
        public Nullable<decimal> ReceivedCash { get; set; }
        public Nullable<decimal> AdditionalDiscount { get; set; }
        public string CashMarkedCounter { get; set; }
    }
}
