using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NewsReader.Shared.Models;
using Newtonsoft.Json;

namespace NewsReader.Shared.Services
{
    public class CloudRssService : IRssService
    {
        public async Task<List<FeedItem>> GetNews(string url)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(new Uri("http://newsapicodemotion2016.azurewebsites.net/api/news"));
            List<FeedItem> items = JsonConvert.DeserializeObject<List<FeedItem>>(result);
            return items;
        }
    }
}
