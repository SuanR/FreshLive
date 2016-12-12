using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreshLiveUI.Admin
{
    public partial class AdminSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "msg", "<script>alert('请先登录');location.href='AdminLogin.aspx'</script>");

            }
            else
            {
                this.Label16.Text = Session["UserName"].ToString();
            }
        }
    }
}