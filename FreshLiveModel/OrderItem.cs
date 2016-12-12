using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshLiveModel
{
    /// <summary>
    /// 订单项表
    /// </summary>
    public class OrderItem
    {
        private int itemID;
        private float payMoney;
        private int productId;
        private string num;
        private int orderID;

        public int ItemID
        {
            get
            {
                return itemID;
            }

            set
            {
                itemID = value;
            }
        }
        /// <summary>
        /// 购买价格
        /// </summary>
        public float PayMoney
        {
            get
            {
                return payMoney;
            }

            set
            {
                payMoney = value;
            }
        }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
            }
        }
        /// <summary>
        /// 购买数量
        /// </summary>
        public string Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }
        /// <summary>
        /// 所属编号
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
    }
}
