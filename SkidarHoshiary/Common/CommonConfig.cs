using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class CommonConfig
    {
        
        public static string CompanyName
        {
            get
            {
                return "Skidar Hosiary";
            }
        }
        public static string CompanyAddress
        {
            get
            {
                return "Kolkata - 700115";
            }
        }
        public static DateTime date
        {
            get
            {
                DateTime dt = DateTime.Now;
                return dt;
            }
        }
        public static string selectedMenu { get; set; }
        public static string mPrintDataStr { get; set; }
    }

