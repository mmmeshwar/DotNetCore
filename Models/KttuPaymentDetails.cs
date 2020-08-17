using System;
using System.Collections.Generic;

namespace DotNetCodeAPI.Models
{
    public partial class KttuPaymentDetails
    {
        public string ObjId { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int SeriesNo { get; set; }
        public int ReceiptNo { get; set; }
        public int Sno { get; set; }
        public string TransType { get; set; }
        public string PayMode { get; set; }
        public string PayDetails { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? PayAmt { get; set; }
        public string RefBillNo { get; set; }
        public string PartyCode { get; set; }
        public string BillCounter { get; set; }
        public string IsPaid { get; set; }
        public string Bank { get; set; }
        public string BankName { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string CardType { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Cflag { get; set; }
        public string CardAppNo { get; set; }
        public string SchemeCode { get; set; }
        public string SalBillType { get; set; }
        public string OperatorCode { get; set; }
        public int? SessionNo { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string GroupCode { get; set; }
        public decimal? AmtReceived { get; set; }
        public decimal? BonusAmt { get; set; }
        public decimal? WinAmt { get; set; }
        public string CtBranch { get; set; }
        public int? FinYear { get; set; }
        public decimal? CardCharges { get; set; }
        public string ChequeNo { get; set; }
        public string NewBillNo { get; set; }
        public decimal? AddDisc { get; set; }
        public string IsOrdermanual { get; set; }
        public decimal? CurrencyValue { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string CurrencyType { get; set; }
        public decimal? TaxPercentage { get; set; }
        public string CancelledBy { get; set; }
        public string CancelledRemarks { get; set; }
        public string CancelledDate { get; set; }
        public string IsExchange { get; set; }
        public int? ExchangeNo { get; set; }
        public string NewReceiptNo { get; set; }
        public decimal? GiftAmount { get; set; }
        public string CardSwipedBy { get; set; }
        public int? Version { get; set; }
        public string GstgroupCode { get; set; }
        public decimal? SgstPercent { get; set; }
        public decimal? CgstPercent { get; set; }
        public decimal? IgstPercent { get; set; }
        public string Hsn { get; set; }
        public decimal? SgstAmount { get; set; }
        public decimal? CgstAmount { get; set; }
        public decimal? IgstAmount { get; set; }
        public decimal? PayAmountBeforeTax { get; set; }
        public decimal? PayTaxAmount { get; set; }
        public Guid UniqRowId { get; set; }
        public int PaymentDetailsId { get; set; }
        public decimal? AdditionalDiscount { get; set; }
        public string IsCashMarking { get; set; }
        public decimal? ReceivedCash { get; set; }
        public string CashMarkedCounter { get; set; }
    }
}
