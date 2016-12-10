using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Process
{
    public class OrderProcess
    {
        public static bool GetOrder(string OrderNo,string item, int qty, string date, string time, string entrymod)
        {
            bool order = OrderDAL.GetOrder(OrderNo,item, qty, date, time, entrymod);
            return order;
        }
    }
}
