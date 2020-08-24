using System;

namespace QuickWriting.Common
{
    /// <summary>
    /// Dto基类
    /// </summary>
    public class BaseDto
    {
        /// <summary>
        /// 字段主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 创建人主键
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        /// 修改人主键
        /// </summary>
        public string ModifyUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyDate { get; set; }
    }
}
