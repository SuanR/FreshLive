using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshLiveModel
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class Order
    {

        private int orderID;
        private int userID;
        private float orderMoney;
        private string orderTime;
        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
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
        /// 订单总价
        /// </summary>
        public float OrderMoney
        {
            get
            {
                return orderMoney;
            }

            set
            {
                orderMoney = value;
            }
        }
        /// <summary>
        /// 订单日期
        /// </summary>
        public string OrderTime
        {
            get
            {
                return orderTime;
            }

            set
            {
                orderTime = value;
            }
        }
    }
}
