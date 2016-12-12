using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshLiveModel
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class UserInfo
    {
        private int userID;
        private string userName;
        private string userPwd;
        private string qQ;
        private string phone;
        private string address;
        private string createTime;

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }
        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
        /// <summary>
        /// 登录名称
        /// </summary>
        public string UserPwd
        {
            get
            {
                return userPwd;
            }

            set
            {
                userPwd = value;
            }
        }
        /// <summary>
        /// QQ
        /// </summary>
        public string QQ
        {
            get
            {
                return qQ;
            }

            set
            {
                qQ = value;
            }
        }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        /// <summary>
        /// 注册日期
        /// </summary>
        public string CreateTime
        {
            get
            {
                return createTime;
            }

            set
            {
                createTime = value;
            }
        }
    }
}
