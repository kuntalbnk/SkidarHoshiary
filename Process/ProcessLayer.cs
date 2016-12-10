using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Process
{
    public class ProcessLayer
    {
        public static int GetLoginStatus(string username,string password,string actionset)
        {
            int loginstatus = DALACESS.GetLoginStatus(username,password,actionset);
            return loginstatus;
        }
    }
}
