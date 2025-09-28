using System;

namespace OneForAll.FF.Core
{

    /// <summary>
    /// 数据库约束特性：Not Null
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class NotNullAttribute:Attribute
    {
    }
}
