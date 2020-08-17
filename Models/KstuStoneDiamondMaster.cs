using System;
using System.Collections.Generic;

namespace DotNetCodeAPI.Models
{
    public partial class KstuStoneDiamondMaster
    {
        public string ObjId { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public string Type { get; set; }
        public string StoneTypes { get; set; }
        public string StoneName { get; set; }
        public string CounterCode { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
        public string Cut { get; set; }
        public string Clarity { get; set; }
        public string ObjStatus { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string Code { get; set; }
        public string Batch { get; set; }
        public string Uom { get; set; }
        public string Hsn { get; set; }
        public decimal? StoneValue { get; set; }
        public string GstgroupCode { get; set; }
        public Guid UniqRowId { get; set; }
        public string OldStoneName { get; set; }
    }
}
