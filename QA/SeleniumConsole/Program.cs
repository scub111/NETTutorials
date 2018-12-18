using System;
using OpenQA.Selenium.Chrome;

namespace SeleniumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            //Console.ReadKey();

            var driver = new ChromeDriver();
            //var driver = new FirefoxDriver();
            driver.Url = "http://scub111.com:9091";
            //driver.Navigate().GoToUrl("http://www.google.ru");
            driver.Close();
        }
    }
}
