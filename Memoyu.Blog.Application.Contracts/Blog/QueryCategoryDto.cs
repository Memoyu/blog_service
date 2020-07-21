﻿/**************************************************************************  
*   =================================
*   CLR版本  ：4.0.30319.42000
*   文件名称 ：QueryCategoryDto
*   =================================
*   创 建 者 ：Memoyu
*   创建日期 ：2020/7/7 9:08:11
*   功能描述 ：
*   =================================
*   修 改 者 ：
*   修改日期 ：
*   修改内容 ：
*   ================================= 
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Memoyu.Blog.Application.Contracts.Blog
{
    public class QueryCategoryDto:CategoryDto
    {
        /// <summary>
        /// 分类Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int Count { get; set; }
    }
}
