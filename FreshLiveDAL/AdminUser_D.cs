using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FreshLiveModel;


namespace FreshLiveDAL
{
   public class AdminUser_D
    {
        public DataTable AdminLogin(AdminUser adminUser)
        {
            string StrSql = string.Format("SELECT * FROM AdminUser WHERE AdminName='{0}' AND AdminPwd='{1}'",adminUser.AdminName,adminUser.AdminPwd);
            return SqlDBHelper.GetDataTable(StrSql);
        }
        public DataTable AdminUserLoad()
        {
            string StrSql = string.Format("SELECT * FROM AdminUser");
            return SqlDBHelper.GetDataTable(StrSql);
        }
    }
}
