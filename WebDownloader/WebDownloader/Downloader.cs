using System;
using System.Net;
using System.Threading.Tasks;

namespace WebDownloader
{
    public class Downloader
    {   
        public async Task<String> DownloadStringAsync(String Url)
        {
            String strResults = null;
            WebClient client = new WebClient();
            strResults = await client.DownloadStringTaskAsync(Url);
            return strResults;
        }

        public async Task<String> DownloadStringWithDefaultCredentialsAsync(String Url)
        {
            String strResults = null;
            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            strResults = await client.DownloadStringTaskAsync(Url);
            return strResults;
        }
    }
}
