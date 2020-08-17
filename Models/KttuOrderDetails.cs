using System;
using System.Collections.Generic;

namespace DotNetCodeAPI.Models
{
    public partial class KttuOrderDetails
    {
        public string ObjId { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int OrderNo { get; set; }
        public int Slno { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal FromGwt { get; set; }
        public decimal ToGwt { get; set; }
        public decimal McPer { get; set; }
        public decimal WstPer { get; set; }
        public decimal Amt { get; set; }
        public string SFlag { get; set; }
        public string SParty { get; set; }
        public int BillNo { get; set; }
        public string ImgId { get; set; }
        public DateTime? UpdateOn { get; set; }
        public decimal VaPercent { get; set; }
        public decimal ItemAmt { get; set; }
        public string GsCode { get; set; }
        public int? FinYear { get; set; }
        public decimal? ItemwiseTaxPercentage { get; set; }
        public decimal? ItemwiseTaxAmount { get; set; }
        public decimal? Mcperpiece { get; set; }
        public string Productid { get; set; }
        public string IsIssued { get; set; }
        public string CounterCode { get; set; }
        public string SalCode { get; set; }
        public decimal? McPercent { get; set; }
        public int? McType { get; set; }
        public Guid UniqRowId { get; set; }
        public int? EstNo { get; set; }
        public string ItemType { get; set; }
        public decimal? AppSwt { get; set; }
        public string BarcodeNo { get; set; }
        public DateTime? DueDateForShipment { get; set; }
        public bool? IsProcessed { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public bool? IsPicked { get; set; }
        public DateTime? PickedDate { get; set; }
        public bool? IsPacked { get; set; }
        public DateTime? PackedDate { get; set; }
        public bool? IsScheduledForPickUp { get; set; }
        public DateTime? ScheduledForPickupDate { get; set; }
        public bool? IsShipped { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? MarketPlaceSno { get; set; }
        public bool? IsGiftWrapRequested { get; set; }
        public bool? IsGiftMessageAdded { get; set; }
        public string GiftMessage { get; set; }
    }
}
