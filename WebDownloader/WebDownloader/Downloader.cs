using System;
using System.Net;
using System.Threading.Tasks;

namespace WebDownloader
{
    public class Downloader
    {
        public async static Task<String> ResultsData(String Url)
        {
            Task<String> data = null;
            WebClient client = new WebClient();
            client.DownloadStringAsync(new Uri(Url), data);
            return await data;
        }
    }
}
