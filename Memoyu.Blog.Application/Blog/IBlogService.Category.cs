﻿/**************************************************************************  
*   =================================
*   CLR版本  ：4.0.30319.42000
*   文件名称 ：IBlogService
*   =================================
*   创 建 者 ：Memoyu
*   创建日期 ：2020/7/3 16:17:22
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
using System.Threading.Tasks;
using Memoyu.Blog.Application.Contracts.Blog;
using Memoyu.Blog.ToolKits.Base;

namespace Memoyu.Blog.Application.Blog
{
    public partial interface IBlogService
    {
        /// <summary>
        /// 查询分类列表（已被引用的分类以及引用数）
        /// </summary>
        /// <returns></returns>
        Task<ServiceResult<IEnumerable<QueryCategoryDto>>> QueryCategoriesAsync();
        /// <summary>
        /// 获取分类名称
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<ServiceResult<string>> GetCategoryAsync(string name);
    }
}
