using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetCodeAPI.Models
{
    public partial class MagnaRJR20072020Context : DbContext
    {
        public MagnaRJR20072020Context()
        {
        }

        public MagnaRJR20072020Context(DbContextOptions<MagnaRJR20072020Context> options)
            : base(options)
        {
        }

        public virtual DbSet<KttuOrderDetails> KttuOrderDetails { get; set; }
        public virtual DbSet<KttuOrderMaster> KttuOrderMaster { get; set; }
        public virtual DbSet<KttuPaymentDetails> KttuPaymentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SISERVER17\\SQL2016;Database=MagnaRJR20072020;user id=magnaapp;password=magna2012");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KttuOrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.ObjId, e.CompanyCode, e.BranchCode, e.OrderNo, e.Slno });

                entity.ToTable("KTTU_ORDER_DETAILS");

                entity.HasIndex(e => e.UniqRowId)
                    .HasName("IX_dbo_KTTU_ORDER_DETAILS_UniqRowID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemName, e.CounterCode, e.BillNo, e.GsCode, e.SalCode, e.SFlag, e.OrderNo })
                    .HasName("IX_KTTU_ORDER_DETAILS");

                entity.Property(e => e.ObjId)
                    .HasColumnName("obj_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasColumnName("company_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasColumnName("branch_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.Slno).HasColumnName("slno");

                entity.Property(e => e.Amt)
                    .HasColumnName("amt")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AppSwt)
                    .HasColumnName("app_swt")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BarcodeNo)
                    .HasColumnName("barcode_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillNo).HasColumnName("bill_no");

                entity.Property(e => e.CounterCode)
                    .HasColumnName("counter_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DueDateForShipment)
                    .HasColumnName("due_date_for_shipment")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstNo).HasColumnName("est_no");

                entity.Property(e => e.FinYear)
                    .HasColumnName("Fin_Year")
                    .HasDefaultValueSql("((2014))");

                entity.Property(e => e.FromGwt)
                    .HasColumnName("from_gwt")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GiftMessage)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.GsCode)
                    .IsRequired()
                    .HasColumnName("gs_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImgId)
                    .HasColumnName("img_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsGiftMessageAdded)
                    .HasColumnName("isGiftMessageAdded")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGiftWrapRequested)
                    .HasColumnName("isGiftWrapRequested")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIssued)
                    .HasColumnName("is_Issued")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsPacked)
                    .HasColumnName("isPacked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPicked)
                    .HasColumnName("isPicked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsProcessed)
                    .HasColumnName("isProcessed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsScheduledForPickUp)
                    .HasColumnName("isScheduledForPickUp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShipped)
                    .HasColumnName("isShipped")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemAmt)
                    .HasColumnName("item_amt")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .HasColumnName("item_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemwiseTaxAmount)
                    .HasColumnName("itemwise_tax_amount")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemwiseTaxPercentage)
                    .HasColumnName("itemwise_tax_percentage")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketPlaceSno).HasColumnName("MarketPlaceSNo");

                entity.Property(e => e.McPer)
                    .HasColumnName("mc_per")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.McPercent)
                    .HasColumnName("mc_percent")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.McType)
                    .HasColumnName("mc_type")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mcperpiece)
                    .HasColumnName("mcperpiece")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PackedDate)
                    .HasColumnName("packed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PickedDate)
                    .HasColumnName("picked_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDate)
                    .HasColumnName("processed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Productid)
                    .HasColumnName("productid")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SFlag)
                    .IsRequired()
                    .HasColumnName("s_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SParty)
                    .IsRequired()
                    .HasColumnName("s_party")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SalCode)
                    .HasColumnName("sal_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScheduledForPickupDate)
                    .HasColumnName("scheduled_for_pickup_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShippedDate)
                    .HasColumnName("shipped_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToGwt)
                    .HasColumnName("to_gwt")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UniqRowId)
                    .HasColumnName("UniqRowID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VaPercent)
                    .HasColumnName("va_percent")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WstPer)
                    .HasColumnName("wst_per")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<KttuOrderMaster>(entity =>
            {
                entity.HasKey(e => new { e.ObjId, e.OrderNo, e.CompanyCode, e.BranchCode });

                entity.ToTable("KTTU_ORDER_MASTER");

                entity.HasIndex(e => e.UniqRowId)
                    .HasName("IX_dbo_KTTU_ORDER_MASTER_UniqRowID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ClosedBy, e.CancelledBy, e.ClosedBranch, e.ClosedDate, e.BillNo })
                    .HasName("IX_KTTU_ORDER_MASTER_ClosingDetails");

                entity.HasIndex(e => new { e.OrderDate, e.OrderNo, e.CustId, e.GsCode, e.Karat, e.DeliveryDate, e.OrderType, e.OldOrderNo, e.ObjectStatus, e.SalCode })
                    .HasName("IX_KTTU_ORDER_MASTER");

                entity.Property(e => e.ObjId)
                    .HasColumnName("obj_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.CompanyCode)
                    .HasColumnName("company_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasColumnName("branch_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalAmount)
                    .HasColumnName("additional_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdvPercent)
                    .HasColumnName("adv_percent")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvanceOrdAmount)
                    .HasColumnName("advance_ord_amount")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.BillCounter)
                    .HasColumnName("bill_counter")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BillNo).HasColumnName("bill_no");

                entity.Property(e => e.BookingType)
                    .HasColumnName("booking_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledBy)
                    .HasColumnName("cancelled_by")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledDate)
                    .HasColumnName("cancelled_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CentralRefNo)
                    .HasColumnName("central_ref_no")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cflag)
                    .IsRequired()
                    .HasColumnName("cflag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClosedBranch)
                    .HasColumnName("closed_branch")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedBy)
                    .HasColumnName("closed_by")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closed_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ClosedFlag)
                    .HasColumnName("closed_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustId).HasColumnName("Cust_Id");

                entity.Property(e => e.CustName)
                    .HasColumnName("cust_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasColumnName("customer_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("delivery_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasColumnName("Email_ID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstNo).HasColumnName("est_no");

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("grand_total")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GsCode)
                    .IsRequired()
                    .HasColumnName("gs_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdDetails)
                    .HasColumnName("id_details")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdType)
                    .HasColumnName("id_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsPan)
                    .HasColumnName("isPAN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Karat)
                    .HasColumnName("karat")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerCode)
                    .HasColumnName("manager_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("mobile_no")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewBillNo)
                    .HasColumnName("New_Bill_No")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([varchar](10),[order_no],(0)))");

                entity.Property(e => e.ObjectStatus)
                    .IsRequired()
                    .HasColumnName("object_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OldOrderNo).HasColumnName("old_order_no");

                entity.Property(e => e.OperatorCode)
                    .IsRequired()
                    .HasColumnName("operator_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAdvanceRateType)
                    .HasColumnName("order_advance_rate_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDayRate)
                    .HasColumnName("order_day_rate")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OrderRateType)
                    .IsRequired()
                    .HasColumnName("order_rate_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderReferenceNo)
                    .HasColumnName("order_reference_no")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSource).HasColumnName("order_source");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo)
                    .HasColumnName("pan_no")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("phone_no")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasColumnName("pin_code")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RateFixedTill)
                    .HasColumnName("rate_fixed_till")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalCode)
                    .IsRequired()
                    .HasColumnName("sal_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnName("shipping_address")
                    .HasMaxLength(1000);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StateCode).HasColumnName("state_code");

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("tax_percentage")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tin)
                    .HasColumnName("tin")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalAmountBeforeTax)
                    .HasColumnName("total_amount_before_tax")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalTaxAmount)
                    .HasColumnName("total_tax_amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UniqRowId)
                    .HasColumnName("UniqRowID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<KttuPaymentDetails>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailsId);

                entity.ToTable("KTTU_PAYMENT_DETAILS");

                entity.HasIndex(e => e.UniqRowId)
                    .HasName("IX_dbo_KTTU_PAYMENT_DETAILS_UniqRowID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.CompanyCode, e.BranchCode, e.SeriesNo, e.ReceiptNo, e.Sno, e.TransType })
                    .HasName("IX_KTTU_PAYMENT_DETAILS_MagnaKey")
                    .IsUnique();

                entity.HasIndex(e => new { e.TransType, e.PayMode, e.SeriesNo, e.ReceiptNo, e.RefBillNo, e.PayDate, e.Cflag })
                    .HasName("IX_KTTU_PAYMENT_DETAILS_AllDeails");

                entity.Property(e => e.PaymentDetailsId).HasColumnName("PaymentDetailsID");

                entity.Property(e => e.AddDisc)
                    .HasColumnName("Add_disc")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdditionalDiscount)
                    .HasColumnName("additional_discount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmtReceived)
                    .HasColumnName("amt_received")
                    .HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasColumnName("bank_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillCounter)
                    .HasColumnName("bill_counter")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BonusAmt)
                    .HasColumnName("bonus_amt")
                    .HasColumnType("decimal(13, 2)");

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasColumnName("branch_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledBy)
                    .HasColumnName("cancelled_by")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CancelledDate)
                    .HasColumnName("cancelled_date")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CancelledRemarks)
                    .HasColumnName("cancelled_remarks")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CardAppNo)
                    .HasColumnName("card_app_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardCharges)
                    .HasColumnType("decimal(13, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSwipedBy)
                    .HasColumnName("cardSwipedBy")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CardType)
                    .HasColumnName("card_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashMarkedCounter)
                    .HasColumnName("cash_marked_Counter")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cflag)
                    .HasColumnName("cflag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CgstAmount)
                    .HasColumnName("CGST_Amount")
                    .HasColumnType("decimal(38, 18)")
                    .HasComputedColumnSql("(round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[CGST_Percent])/(100),(2)))");

                entity.Property(e => e.CgstPercent)
                    .HasColumnName("CGST_Percent")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChequeDate)
                    .HasColumnName("cheque_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChequeNo)
                    .HasColumnName("cheque_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasColumnName("company_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtBranch)
                    .HasColumnName("ct_branch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyType)
                    .HasColumnName("currency_type")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyValue)
                    .HasColumnName("currency_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExchangeNo)
                    .HasColumnName("exchangeNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchange_rate")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("expiry_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinYear).HasColumnName("fin_year");

                entity.Property(e => e.GiftAmount)
                    .HasColumnName("Gift_Amount")
                    .HasColumnType("decimal(13, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstgroupCode)
                    .HasColumnName("GSTGroupCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hsn)
                    .HasColumnName("HSN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IgstAmount)
                    .HasColumnName("IGST_Amount")
                    .HasColumnType("decimal(38, 18)")
                    .HasComputedColumnSql("(round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[IGST_Percent])/(100),(2)))");

                entity.Property(e => e.IgstPercent)
                    .HasColumnName("IGST_Percent")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCashMarking)
                    .HasColumnName("isCashMarking")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsExchange)
                    .HasColumnName("isExchange")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsOrdermanual)
                    .HasColumnName("isOrdermanual")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsPaid)
                    .HasColumnName("is_paid")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NewBillNo)
                    .HasColumnName("New_Bill_No")
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [trans_type]='AP' then 'PPV'+CONVERT([varchar],[series_no],(0)) else CONVERT([varchar],[series_no],(0)) end)");

                entity.Property(e => e.NewReceiptNo)
                    .HasColumnName("new_receipt_no")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([varchar],[receipt_no],(0)))");

                entity.Property(e => e.ObjId)
                    .IsRequired()
                    .HasColumnName("obj_id")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorCode)
                    .HasColumnName("operator_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartyCode)
                    .HasColumnName("party_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayAmountBeforeTax)
                    .HasColumnName("pay_amount_before_tax")
                    .HasColumnType("decimal(38, 18)")
                    .HasComputedColumnSql("([pay_amt]-round((round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[SGST_Percent])/(100),(2))+round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[CGST_Percent])/(100),(2)))+round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[IGST_Percent])/(100),(2)),(2)))");

                entity.Property(e => e.PayAmt)
                    .HasColumnName("pay_amt")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PayDate)
                    .HasColumnName("pay_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayDetails)
                    .HasColumnName("pay_details")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayMode)
                    .HasColumnName("pay_mode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PayTaxAmount)
                    .HasColumnName("pay_tax_amount")
                    .HasColumnType("decimal(38, 18)")
                    .HasComputedColumnSql("(round((round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[SGST_Percent])/(100),(2))+round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[CGST_Percent])/(100),(2)))+round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[IGST_Percent])/(100),(2)),(2)))");

                entity.Property(e => e.ReceiptNo).HasColumnName("receipt_no");

                entity.Property(e => e.ReceivedCash)
                    .HasColumnName("received_cash")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefBillNo)
                    .HasColumnName("Ref_BillNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalBillType)
                    .HasColumnName("sal_bill_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeCode)
                    .HasColumnName("scheme_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SeriesNo).HasColumnName("series_no");

                entity.Property(e => e.SessionNo)
                    .HasColumnName("session_no")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SgstAmount)
                    .HasColumnName("SGST_Amount")
                    .HasColumnType("decimal(38, 18)")
                    .HasComputedColumnSql("(round((([pay_amt]/((1)+(([SGST_Percent]+[CGST_Percent])+[IGST_Percent])/(100)))*[SGST_Percent])/(100),(2)))");

                entity.Property(e => e.SgstPercent)
                    .HasColumnName("SGST_Percent")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.TaxPercentage)
                    .HasColumnName("tax_percentage")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("trans_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UniqRowId)
                    .HasColumnName("UniqRowID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WinAmt)
                    .HasColumnName("win_amt")
                    .HasColumnType("decimal(13, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
