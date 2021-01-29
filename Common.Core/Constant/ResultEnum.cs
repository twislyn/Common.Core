using System;
namespace Common.Core.Constant
{
    public enum ResultEnum : long
    {
        [BaseDescription("SUCCEED", "业务处理成功")]
        SUCCEED = 1,

        [BaseDescription("FAILED", "业务处理失败")]
        FAILED = 0
    }
}
