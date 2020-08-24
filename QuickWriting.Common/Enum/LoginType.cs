using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWriting.Common.Enum
{
    /// <summary>
    /// 允许登陆类型
    /// </summary>
    public enum LoginType
    {
        Web = 2,
        Client = 4,
        WeChat = 8,
        Android = 16,
        iOS = 32,
        OAuth = 64,
        AliPay = 128
    }
}
