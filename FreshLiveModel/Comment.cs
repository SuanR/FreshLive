using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshLiveModel
{
    /// <summary>
    /// 评论表
    /// </summary>
    public class Comment
    {
        private int commentID;
        private int userID;
        private int productID;
        private string commentContent;
        private int star;
        private string commentTime;
        /// <summary>
        /// 
        /// </summary>
        public int CommentID
        {
            get
            {
                return commentID;
            }

            set
            {
                commentID = value;
            }
        }
        /// <summary>
        /// 用户编号
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
        /// 商品编号
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
        /// 评论内容
        /// </summary>
        public string CommentContent
        {
            get
            {
                return commentContent;
            }

            set
            {
                commentContent = value;
            }
        }
        /// <summary>
        /// 评分
        /// </summary>
        public int Star
        {
            get
            {
                return star;
            }

            set
            {
                star = value;
            }
        }
        /// <summary>
        /// 评论日期
        /// </summary>
        public string CommentTime
        {
            get
            {
                return commentTime;
            }

            set
            {
                commentTime = value;
            }
        }
    }
}
