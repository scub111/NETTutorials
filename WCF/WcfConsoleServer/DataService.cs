using System;
using System.ServiceModel;

namespace WcfConsoleServer
{
    [ServiceContract]
    public class DataService
    {
        [OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "/Test123", ResponseFormat = WebMessageFormat.Json)]
        public string Test1234()
        {
            Console.WriteLine("Client request.");
            return "Test done";
        }
    }
}
