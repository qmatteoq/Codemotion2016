using System.Collections.Generic;
using System.Threading.Tasks;
using NewsReader.Shared.Models;

namespace NewsReader.Shared.Services
{
    public interface IRssService
    {
        Task<List<FeedItem>> GetNews(string url);
    }
}
