﻿using System;

namespace OneForAll.FF.Core
{

    /// <summary>
    /// 数据库约束特性：默认值
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DefaultAttribute:Attribute
    {

    }
}
