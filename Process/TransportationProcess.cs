using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    public class TransportationProcess
    {
        public static string GetPurchaseQtyData(string ItemType)
        {
            string purchaseqty = string.Empty;
            if (!string.IsNullOrEmpty(ItemType))
            {
                purchaseqty = TransportationDAL.GetPurchaseData(ItemType);
            }
            return purchaseqty;
        }

        public static bool InsertTransportedData(string Item, string purchaseqty, string transqty, string vno, string gno,
            string tranddt, string transtime, string estdt)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(Item) && !string.IsNullOrEmpty(purchaseqty) && !string.IsNullOrEmpty(transqty) && !string.IsNullOrEmpty(vno) &&
                !string.IsNullOrEmpty(gno) && !string.IsNullOrEmpty(tranddt) && !string.IsNullOrEmpty(transtime) && !string.IsNullOrEmpty(estdt))
            {
                result = TransportationDAL.InsertTransportData(Item, purchaseqty, transqty, vno, gno, tranddt, transtime, estdt);
            }
            return result;
        }

        public static DataTable GetItem()
        {
            DataTable dt = DAL.TransportationDAL.GetItemValue();
            return dt;
        }
        public static DataTable GetGodown()
        {
            DataTable dt = DAL.TransportationDAL.GetGodownValue();
            return dt;
        }
    }
}
