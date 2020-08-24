using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QuickWriting.Common.Enum
{
    /// <summary>
    /// 性别枚举
    /// </summary>
    public enum Gender
    {
        [Description("男")]
        男 = 1,

        [Description("女")]
        女 = 0,
    }
}
