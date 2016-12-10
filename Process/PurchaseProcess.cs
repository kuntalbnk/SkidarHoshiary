using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    public class PurchaseProcess
    {
        public static string GetOrderQtyData(string ItemType)
        {
            string orderQty = string.Empty;
            if (!string.IsNullOrEmpty(ItemType))
            {
                orderQty = PurchaseDAL.GetPurchaseData(ItemType);
            }
            return orderQty;
        }

        public static bool InsertPurchaseOrderProcess(string Item, string CompanyName, string Address, string Pin, string ContactPerson,
            string ContactNo, string Qty, string Rate, string WBTax, string Cst, string ItemCost, string Amount)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(Item) && !string.IsNullOrEmpty(CompanyName) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(Pin) &&
                !string.IsNullOrEmpty(ContactPerson) && !string.IsNullOrEmpty(ContactNo) && !string.IsNullOrEmpty(Qty) && !string.IsNullOrEmpty(Rate)
                 && !string.IsNullOrEmpty(Cst) && !string.IsNullOrEmpty(ItemCost) && !string.IsNullOrEmpty(Amount))
            {
                result = PurchaseDAL.InsertPurchaseData(Item, CompanyName, Address, Pin, ContactPerson, ContactNo, Qty, Rate, WBTax, Cst, ItemCost, Amount);
            }
            return result;
        }

        public static DataTable GetItem()
        {
            DataTable dt = DAL.PurchaseDAL.GetItemValue();
            return dt;
        }
    }
}
