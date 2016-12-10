using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Process
{
    public class CompanyProcess
    {
        public static bool GetCompany(string companyname, string adress, string pin,string vat,string phone,string email,string entrymod)
        {
            bool company = CompanyDAL.GetCompany(companyname, adress, pin, vat, phone, email, entrymod);
            return company;
        }
    }
}
