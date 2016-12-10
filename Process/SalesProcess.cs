using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Process
{
    public class SalesProcess
    {
        public static string GetpurchaseQtyData(string ItemType)
        {
            string orderQty = string.Empty;
            if (!string.IsNullOrEmpty(ItemType))
            {
                orderQty = SalesDAL.GetPurchaseData(ItemType);
            }
            return orderQty;
        }
         public static string GetpurchaserateData(string ItemType)
        {
            string rate = string.Empty;
            if (!string.IsNullOrEmpty(ItemType))
            {
                rate = SalesDAL.GetPurchaserateData(ItemType);
            }
            return rate;
        }
         public static string billchk(string bill)
         {
             string billno = string.Empty;
             if (!string.IsNullOrEmpty(bill))
             {
                 billno = SalesDAL.billchk(bill);
             }
             return billno;
         }
        public static bool InsertSalesData(string mode,string name,string addr,string contact,string orderno,string salesqty,string rate,string dis,string amt,string billno)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(billno) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(addr) && !string.IsNullOrEmpty(contact) && !string.IsNullOrEmpty(orderno) &&
                !string.IsNullOrEmpty(salesqty) && !string.IsNullOrEmpty(rate) && !string.IsNullOrEmpty(amt))
            {
                result = SalesDAL.InsertSalesEntry(mode,  name, addr, contact, orderno, salesqty, rate, dis, amt,billno);
            }
            return result;
        }
        public static DataTable GetItem()
        {
            DataTable dt = DAL.SalesDAL.GetItemValue();
            return dt;
        }
    }
    }

