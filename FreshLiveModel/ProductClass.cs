using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshLiveModel
{
    /// <summary>
    /// 商品分类表
    /// </summary>
    public class ProductClass
    {
        private int classID;
        private string className;
        private int parentClassID;
        /// <summary>
        /// 
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
        /// 类型名称
        /// </summary>
        public string ClassName
        {
            get
            {
                return className;
            }

            set
            {
                className = value;
            }
        }
        /// <summary>
        /// 父类ID
        /// </summary>
        public int ParentClassID
        {
            get
            {
                return parentClassID;
            }

            set
            {
                parentClassID = value;
            }
        }
    }
}
