using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace Process
{
   public class ReportProcess
    {
        public static DataTable GetGodownsReportProcess()
        {
            DataTable dt = ReportDAL.GetGodownReportData();
            return dt.Rows.Count > 0 ? dt : null;
        }
        public static DataTable GetCompanyReportProcess()
        {
            DataTable dt = ReportDAL.GetCompanyReportData();
            return dt.Rows.Count > 0 ? dt : null;
        }
        public static DataTable GetOrderReportProcess()
        {
            DataTable dt = ReportDAL.GetOrderReportData();
            return dt.Rows.Count > 0 ? dt : null;
        }
        public static DataTable GetPurchaseReportProcess()
        {
            DataTable dt = ReportDAL.GetPurchaseReportData();
            return dt.Rows.Count > 0 ? dt : null;
        }
        public static DataTable GetTransReportProcess()
        {
            DataTable dt = ReportDAL.GetTransReportData();
            return dt.Rows.Count > 0 ? dt : null;
        }
    }
}
