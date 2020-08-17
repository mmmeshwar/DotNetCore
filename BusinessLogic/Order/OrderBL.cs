using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCodeAPI.BusinessObjects;
using DotNetCodeAPI.Models;
using Microsoft.Extensions.Configuration;

namespace DotNetCodeAPI.BusinessLogic.Order
{
    public class OrderBL
    {
        private readonly MagnaRJR20072020Context db= new MagnaRJR20072020Context();
        public OrderMasterVM GetOrderInfo(string companyCode, string branchCode, int orderNo, out ErrorVM error)
        {
            try
            {
                KttuOrderMaster kom = new KttuOrderMaster();
                List<KttuOrderDetails> kod = new List<KttuOrderDetails>();
                List<KttuPaymentDetails> kpd = new List<KttuPaymentDetails>();

                kom = db.KttuOrderMaster.Where(ord => ord.OrderNo == orderNo
                                                    && ord.CompanyCode == companyCode
                                                    && ord.BranchCode == branchCode).FirstOrDefault();
                kod = db.KttuOrderDetails.Where(ord => ord.OrderNo == orderNo
                                                    && ord.CompanyCode == companyCode
                                                    && ord.BranchCode == branchCode).ToList();
                kpd = db.KttuPaymentDetails.Where(ord => ord.SeriesNo == orderNo
                                                    && ord.Cflag == "N"
                                                    && ord.TransType == "O"
                                                    && ord.CompanyCode == companyCode
                                                    && ord.BranchCode == branchCode).ToList().OrderBy(ord => ord.PayDate).ToList();

                error = null;
                if (kom == null)
                {
                    error = new ErrorVM()
                    {
                        field = "Order Number",
                        index = 0,
                        description = "Invalid Order Number",
                        ErrorStatusCode = System.Net.HttpStatusCode.BadRequest
                    };
                    return null;
                }

                if (kom.Cflag == "Y")
                {
                    error = new ErrorVM()
                    {
                        field = "Order Number",
                        index = 0,
                        description = "Order NO: " + orderNo + " is already cancelled.",
                        ErrorStatusCode = System.Net.HttpStatusCode.BadRequest
                    };
                    return null;
                }

                if (kom.ClosedFlag == "Y")
                {
                    error = new ErrorVM()
                    {
                        field = "Order Number",
                        index = 0,
                        description = "Order NO: " + orderNo + " is already closed.",
                        ErrorStatusCode = System.Net.HttpStatusCode.BadRequest
                    };
                    return null;
                }

                if (kom.BillNo != 0)
                {
                    error = new ErrorVM()
                    {
                        field = "Order Number",
                        index = 0,
                        description = "Order NO: " + orderNo + " is already adjusted towords Bill No: " + kom.BillNo + " Updated date: " + Convert.ToDateTime(kom.UpdateOn).ToString("dd/MM/yyyy") + "",
                        ErrorStatusCode = System.Net.HttpStatusCode.BadRequest
                    };
                    return null;
                }

                #region Order Master Details
                OrderMasterVM om = new OrderMasterVM();
                om.ObjID = kom.ObjId;
                om.CompanyCode = kom.CompanyCode;
                om.BranchCode = kom.BranchCode;
                om.OrderNo = kom.OrderNo;
                om.CustID = kom.CustId;
                om.CustName = kom.CustName;
                om.OrderType = kom.OrderType;
                om.Remarks = kom.Remarks;
                om.OrderDate = kom.OrderDate;
                om.OperatorCode = kom.OperatorCode;
                om.SalCode = kom.SalCode;
                om.DeliveryDate = kom.DeliveryDate;
                om.OrderRateType = kom.OrderRateType;
                om.gsCode = kom.GsCode;
                om.Rate = kom.Rate;
                om.AdvacnceOrderAmount = kom.AdvanceOrdAmount;
                om.GrandTotal = kom.GrandTotal;
                om.ObjectStatus = kom.ObjectStatus;
                om.BillNo = kom.BillNo;
                om.CFlag = kom.Cflag;
                om.CancelledBy = kom.CancelledBy;
                om.BillCounter = kom.BillCounter;
                om.UpdateOn = kom.UpdateOn;
                om.ClosedBranch = kom.ClosedBranch;
                om.ClosedFlag = kom.ClosedFlag;
                om.ClosedBy = kom.ClosedBy;
                om.ClosedDate = kom.ClosedDate;
                om.Karat = kom.Karat;
                om.OrderDayRate = kom.OrderDayRate;
                om.NewBillNo = kom.NewBillNo;
                om.TaxPercentage = kom.TaxPercentage;
                om.TotalAmountBeforeTax = kom.TotalAmountBeforeTax;
                om.TotalTaxAmount = kom.TotalTaxAmount;
                om.ShiftID = kom.ShiftId;
                om.IsPAN = kom.IsPan;
                om.OldOrderNo = kom.OldOrderNo;
                om.Address1 = kom.Address1;
                om.Address2 = kom.Address2;
                om.Address3 = kom.Address3;
                om.City = kom.City;
                om.PinCode = kom.PinCode;
                om.MobileNo = kom.MobileNo;
                om.State = kom.State;
                om.StateCode = kom.StateCode;
                om.TIN = kom.Tin;
                om.PANNo = kom.PanNo;
                om.ESTNo = kom.EstNo;
                om.IDType = kom.IdType;
                om.IDDetails = kom.IdDetails;
                om.BookingType = kom.BookingType;
                om.PhoneNo = kom.PhoneNo;
                om.EmailID = kom.EmailId;
                om.Salutation = kom.Salutation;
                om.ManagerCode = kom.ManagerCode;
                #endregion

                #region Order Details
                List<OrderItemDetailsVM> lstOfOrderDetils = new List<OrderItemDetailsVM>();
                foreach (KttuOrderDetails orderDet in kod)
                {
                    OrderItemDetailsVM oid = new OrderItemDetailsVM();
                    oid.ObjID = orderDet.ObjId;
                    oid.CompanyCode = orderDet.CompanyCode;
                    oid.BranchCode = orderDet.BranchCode;
                    oid.OrderNo = orderDet.OrderNo;
                    oid.SlNo = orderDet.Slno;
                    oid.ItemName = orderDet.ItemName;
                    oid.Quantity = orderDet.Quantity;
                    oid.Description = orderDet.Description;
                    oid.FromGrossWt = orderDet.FromGwt;
                    oid.ToGrossWt = orderDet.ToGwt;
                    oid.MCPer = orderDet.McPer;
                    oid.WastagePercent = orderDet.WstPer;
                    oid.Amount = orderDet.Amt;
                    oid.SFlag = orderDet.SFlag;
                    oid.SParty = orderDet.SParty;
                    oid.BillNo = orderDet.BillNo;
                    oid.ImgID = orderDet.ImgId;
                    oid.UpdateOn = orderDet.UpdateOn;
                    oid.VAPercent = orderDet.VaPercent;
                    oid.ItemAmount = orderDet.ItemAmt;
                    oid.GSCode = orderDet.GsCode;
                    oid.FinYear = orderDet.FinYear;
                    oid.ItemwiseTaxPercentage = orderDet.ItemwiseTaxPercentage;
                    oid.ItemwiseTaxAmount = orderDet.ItemwiseTaxAmount;
                    oid.MCPerPiece = orderDet.Mcperpiece;
                    oid.ProductID = orderDet.Productid;
                    oid.IsIssued = orderDet.IsIssued;
                    oid.CounterCode = orderDet.CounterCode;
                    oid.SalCode = orderDet.SalCode;
                    oid.MCPercent = orderDet.McPercent;
                    oid.MCType = orderDet.McType;
                    oid.EstNo = orderDet.EstNo;
                    oid.ItemType = orderDet.ItemType;
                    oid.AppSwt = orderDet.AppSwt;
                    lstOfOrderDetils.Add(oid);
                }
                om.lstOfOrderItemDetailsVM = lstOfOrderDetils;
                #endregion

                #region Payment Details
                List<PaymentVM> lstOfPayment = new List<PaymentVM>();
                foreach (KttuPaymentDetails paymentDet in kpd)
                {
                    PaymentVM payment = new PaymentVM();
                    payment.ObjID = paymentDet.ObjId;
                    payment.CompanyCode = paymentDet.CompanyCode;
                    payment.BranchCode = paymentDet.BranchCode;
                    payment.SeriesNo = paymentDet.SeriesNo;
                    payment.ReceiptNo = paymentDet.ReceiptNo;
                    payment.SNo = paymentDet.Sno;
                    payment.TransType = paymentDet.TransType;
                    payment.PayMode = paymentDet.PayMode;
                    payment.PayDetails = paymentDet.PayDetails;
                    payment.PayDate = paymentDet.PayDate;
                    payment.PayAmount = paymentDet.PayAmt;
                    // payment.RefBillNo = paymentDet.Ref_BillNo;
                    // payment.PartyCode = paymentDet.party_code;
                    // payment.BillCounter = paymentDet.bill_counter;
                    // payment.IsPaid = paymentDet.is_paid;
                    // payment.Bank = paymentDet.bank;
                    // payment.BankName = paymentDet.bank_name;
                    // payment.ChequeDate = paymentDet.cheque_date;
                    // payment.CardType = paymentDet.card_type;
                    // payment.ExpiryDate = paymentDet.expiry_date;
                    // payment.CFlag = paymentDet.cflag;
                    // payment.CardAppNo = paymentDet.card_app_no;
                    // payment.SchemeCode = paymentDet.scheme_code;
                    // payment.SalBillType = paymentDet.sal_bill_type;
                    // payment.OperatorCode = paymentDet.operator_code;
                    // payment.SessionNo = paymentDet.session_no;
                    // payment.UpdateOn = paymentDet.UpdateOn;
                    // payment.GroupCode = paymentDet.group_code;
                    // payment.AmtReceived = paymentDet.amt_received;
                    // payment.BonusAmt = paymentDet.bonus_amt;
                    // payment.WinAmt = paymentDet.win_amt;
                    // payment.CTBranch = paymentDet.ct_branch;
                    // payment.FinYear = paymentDet.fin_year;
                    // payment.CardCharges = paymentDet.CardCharges;
                    // payment.ChequeNo = paymentDet.cheque_no;
                    // payment.NewBillNo = paymentDet.new_receipt_no;
                    // payment.AddDisc = paymentDet.Add_disc;
                    // payment.IsOrderManual = paymentDet.isOrdermanual;
                    // payment.CurrencyValue = paymentDet.currency_value;
                    // payment.ExchangeRate = paymentDet.exchange_rate;
                    // payment.CurrencyType = paymentDet.currency_type;
                    // payment.TaxPercentage = paymentDet.tax_percentage;
                    // payment.CancelledBy = paymentDet.cancelled_by;
                    // payment.CancelledRemarks = paymentDet.cancelled_remarks;
                    // payment.CancelledDate = paymentDet.cancelled_date;
                    // payment.IsExchange = paymentDet.isExchange;
                    // payment.ExchangeNo = paymentDet.exchangeNo;
                    // payment.NewReceiptNo = paymentDet.new_receipt_no;
                    // payment.GiftAmount = paymentDet.Gift_Amount;
                    // payment.CardSwipedBy = paymentDet.cardSwipedBy;
                    // payment.Version = paymentDet.version;
                    // payment.GSTGroupCode = paymentDet.GSTGroupCode;
                    // payment.SGSTPercent = paymentDet.SGST_Percent;
                    // payment.CGSTPercent = paymentDet.CGST_Percent;
                    // payment.IGSTPercent = paymentDet.IGST_Percent;
                    // payment.HSN = paymentDet.HSN;
                    // payment.SGSTAmount = paymentDet.SGST_Amount;
                    // payment.CGSTAmount = paymentDet.CGST_Amount;
                    // payment.IGSTAmount = paymentDet.IGST_Amount;
                    // payment.PayAmountBeforeTax = paymentDet.pay_amount_before_tax;
                    // payment.PayTaxAmount = paymentDet.pay_tax_amount;
                    lstOfPayment.Add(payment);
                }
                om.lstOfPayment = lstOfPayment;
                #endregion

                return om;
            }
            catch (Exception excp)
            {
                error = new ErrorVM()
                {
                    field = "Internal Server Error",
                    index = 0,
                    description = excp.Message,
                    ErrorStatusCode = System.Net.HttpStatusCode.InternalServerError
                };
                return null;
            }
        }
    }
}