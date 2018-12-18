using System;
using System.ServiceModel;

namespace WcfConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var host = new ServiceHost(typeof(WcfServiceLibrary.Service1));
                var host = new ServiceHost(typeof(DataService));
                host.Open();
                Console.WriteLine($"Service Hosted Sucessfully on {host.BaseAddresses[0].AbsoluteUri}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Source}: {e.Message}");
            }

            Console.Read();
        }
    }
}
