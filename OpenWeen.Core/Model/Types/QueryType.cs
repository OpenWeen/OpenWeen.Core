﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeen.Core.Model.Types
{
    public enum QueryType
    {
        /// <summary>
        /// 微博
        /// </summary>
        Weibo = 1,
        /// <summary>
        /// 评论
        /// </summary>
        Comment,
        /// <summary>
        /// 私信
        /// </summary>
        DirectMessage = 3,
    }
}
