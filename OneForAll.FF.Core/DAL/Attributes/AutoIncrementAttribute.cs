﻿using System;

namespace OneForAll.FF.Core
{

    /// <summary>
    /// 数据库约束特性：自增
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class AutoIncrementAttribute: Attribute
    {

    }
}
