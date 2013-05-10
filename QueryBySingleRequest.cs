﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenArmsSeries.Repositories
{
    /// <summary>
    /// 单记录查询请求对象
    /// </summary>
    public class QueryBySingleRequest:Request
    {
        private string _paramPlus = string.Empty;
        /// <summary>
        /// 查询条件 用于复杂的查询页面，接收前台拼接好的sql语句条件 用于字符串替换默认为{0}
        /// </summary>
        public string ParamPlus
        {
            get
            {
                return string.IsNullOrWhiteSpace(_paramPlus) ? " 1=1 " : _paramPlus;
            }
            set { _paramPlus = value; }
        }

        private Dictionary<string, string> _paramSort = new Dictionary<string, string>();
        /// <summary>
        /// 排序条件 关键字:排序 对应于系统后台实现规则(asc|desc)， 转换后 用于字符串替换默认为{1}
        /// </summary>
        public Dictionary<string, string> ParamSort { get { return _paramSort; } set { _paramSort = value; } }

   
    }
}