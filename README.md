# OneForAll.FF.Core
.NET Framework 框架核心类库

## 简介
OneForAll.FF.Core 是专为 .NET Framework 环境设计的核心工具库，提供通用的基础设施封装，包括结果返回、分页模型、扩展方法、常用工具类等，适用于 ASP.NET、WinForms、WPF 等 .NET Framework 项目。

## 注意：仅限 .NET Framework
本库仅支持 .NET Framework 4.6.2 及以上版本。  
如需 .NET Core / .NET 5+ 版本，请使用：
https://www.nuget.org/packages/OneForAll.Core/

## 使用示例
// 统一返回结果
var result = new BaseMessage();

// 分页数据
var page = PageList<User>(int total, int pageSize, int pageIndex, IEnumerable<T> items);

// 扩展方法（如字符串、日期、对象等）
"hello".IsNullOrEmpty();

## 许可证
MIT License