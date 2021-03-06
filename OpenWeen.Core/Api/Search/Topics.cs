﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenWeen.Core.Helper;
using OpenWeen.Core.Model.Status;

namespace OpenWeen.Core.Api.Search
{
    public class Topics
    {
        public static async Task<MessageListModel> GetSearchTopics(string q, int count, int page)
        {
            Dictionary<string, string> param = new Dictionary<string, string>()
            {
                { nameof(q), q},
                { nameof(count), count.ToString() },
                { nameof(page), page.ToString() },
            };
            return JsonConvert.DeserializeObject<MessageListModel>(await HttpHelper.GetStringAsync(Constants.SEARCH_TOPICS, param));
        }
    }
}