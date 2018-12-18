using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static async Task<string> DownloadSomething()
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync("http://www.microsoft.com");
            }
        }

        static void Main(string[] args)
        {
            var result = DownloadSomething().Result;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
