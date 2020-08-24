using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWriting.Common.Entity
{
    /// <summary>
    /// 字段长度限制实体
    /// </summary>
    public class FieldLimitBaseDto
    {
        /// <summary>
        /// 名称最大长度
        /// </summary>
        public const int MaxNameLength = 32;

        /// <summary>
        /// 备注最大长度
        /// </summary>
        public const int MaxRemarkLength = 225;
    }
}
