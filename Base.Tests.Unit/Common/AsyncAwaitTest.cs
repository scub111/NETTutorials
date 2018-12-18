using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class AsyncAwaitTest
    {
        public static async Task<string> DownloadSomething()
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync("http://www.microsoft.com");
            }
        }

        [Test]
        public void TestCase()
        {
            var result = DownloadSomething().Result;
            result.Length.Should().BeGreaterOrEqualTo(100);
        }
    }
}
