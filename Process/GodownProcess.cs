using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Process
{
   public class GodownProcess
    {
       public static bool GetGodown(string godownname, string adress, string pin,string phone,string entrymod)
       {
           bool godown = GodownDAL.GetGodown(godownname, adress, pin, phone, entrymod);
           return godown;
       }
    }
}
