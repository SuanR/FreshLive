using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshLiveModel
{
    /// <summary>
    /// 管理员信息表
    /// </summary>
    public class AdminUser
    {
        private int    adminID;
        private string adminName;
        private string adminPwd;
        /// <summary>
        /// 管理员编号
        /// </summary>
        public int AdminID
        {
            get
            {
                return adminID;
            }

            set
            {
                adminID = value;
            }
        }
        /// <summary>
        /// 管理员登录账号
        /// </summary>
        public string AdminName
        {
            get
            {
                return adminName;
            }

            set
            {
                adminName = value;
            }
        }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPwd
        {
            get
            {
                return adminPwd;
            }

            set
            {
                adminPwd = value;
            }
        }
    }
}
