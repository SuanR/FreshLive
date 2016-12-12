using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshLiveModel;
using FreshLiveDAL;
using System.Data;

namespace FreshLiveBLL
{
  public  class AdminUser_B
    {
        public DataTable AdminLogin(AdminUser adminUser)
        {
            AdminUser_D adminUser_D = new AdminUser_D();
            return adminUser_D.AdminLogin(adminUser);
        }
        public DataTable AdminUserLoad()
        {
            AdminUser_D adminUser_D = new AdminUser_D();
            return adminUser_D.AdminUserLoad();
        }
    }
}
