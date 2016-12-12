using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FreshLiveModel;
using FreshLiveBLL;
using System.Web.Security;

namespace FreshLiveUI.Admin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sure_Click(object sender, EventArgs e)
        {
            AdminUser adminUser = new AdminUser();
            adminUser.AdminName = this.txt_username.Text;
            adminUser.AdminPwd = this.txt_pwd.Text;
            AdminUser_B adminUser_B = new AdminUser_B();
            if (adminUser_B.AdminLogin(adminUser).Rows.Count > 0)
            {
                Response.Write("<script>alert('登录成功')</script>");
                Session["UserName"] = this.txt_username.Text;
                FormsAuthentication.RedirectFromLoginPage("UserName", false);
                Response.Redirect("AdminUserForm.aspx");
            }
            else
            {
                Response.Write("<script>alert('登录失败')</script>");
            }
        }
    }
}