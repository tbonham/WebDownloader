using System;
using System.Net;

using System.Threading.Tasks;
using WebDownloader;

namespace DownloaderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://data.ny.gov/api/views/5xaw-6ayf/rows.json?accessType=DOWNLOAD";
            Downloader downloader = new Downloader();
            Console.WriteLine("Starting {0}", DateTime.Now.ToString());
            Task<String> resultsTask = downloader.DownloadStringAsync(url);
            Console.WriteLine("End {0}", DateTime.Now.ToString());
            Console.WriteLine("Please enter to see results.");
            Console.ReadLine();
            Console.WriteLine(resultsTask.Result.ToString());
        }
    }
}
