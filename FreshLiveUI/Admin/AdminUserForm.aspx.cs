using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshLiveBLL;
using System.Data;

namespace FreshLiveUI.Admin
{
    public partial class AdminUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AdminUser_B adminUser_B = new AdminUser_B();
                this.rpt_departmentMng.DataSource = adminUser_B.AdminUserLoad();
                this.rpt_departmentMng.DataBind();
            }
        }
    }
}