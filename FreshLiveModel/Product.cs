using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshLiveModel
{
    /// <summary>
    /// 商品信息表
    /// </summary>
    public class Product
    {
        private int    productID;
        private string productName;
        private string productPic;
        private float  productPrice;
        private string productDesc;
        private int    classID;
        private string addTime;
        /// <summary>
        /// 商品信息ID
        /// </summary>
        public int ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }
        /// <summary>
        /// 商品名
        /// </summary>
        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }
        /// <summary>
        /// 图片
        /// </summary>
        public string ProductPic
        {
            get
            {
                return productPic;
            }

            set
            {
                productPic = value;
            }
        }
        /// <summary>
        /// 价格
        /// </summary>
        public float ProductPrice
        {
            get
            {
                return productPrice;
            }

            set
            {
                productPrice = value;
            }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public string ProductDesc
        {
            get
            {
                return productDesc;
            }

            set
            {
                productDesc = value;
            }
        }
        /// <summary>
        /// 分类
        /// </summary>
        public int ClassID
        {
            get
            {
                return classID;
            }

            set
            {
                classID = value;
            }
        }
        /// <summary>
        /// 商家
        /// </summary>
        public string AddTime
        {
            get
            {
                return addTime;
            }

            set
            {
                addTime = value;
            }
        }
    }
}
