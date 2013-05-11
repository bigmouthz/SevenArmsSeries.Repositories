using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenArmsSeries.Repositories
{
    /// <summary>
    /// 多记录查询请求对象
    /// </summary>
    public class QueryByMoreRequest : QueryBySingleRequest
    {
        /// <summary>
        /// 是否分页
        /// </summary>
        public bool IsPaging { get; set; }

        private int _pageIndex;
        /// <summary>
        /// 分页情况下的，当前页面，下标为1起
        /// </summary>
        public int PageIndex { get { return _pageIndex <= 0 ? 1 : _pageIndex; } set { _pageIndex = value; } }

        private int _pageSize;
        /// <summary>
        /// 分页情况下的，页面尺寸，最少为1起
        /// </summary>
        public int PageSize { get { return _pageSize <= 0 ? 1 : _pageSize; } set { _pageSize = value; } }
  
        /// <summary>
        /// 是否启用页面缓存，仅当页面缓存有效时才有用
        /// </summary>
        public bool IsCachePage { get; set; }

        /// <summary>
        /// 恒等于 启用分页下的当前页面（后台无意义，前台用于控制用）
        /// </summary>
        public int _cachePageIndex { get; set; }

        /// <summary>
        /// 缓存情况下，缓存页面数
        /// </summary>
        public int CahcePageCount { get; set; }

    }
}
