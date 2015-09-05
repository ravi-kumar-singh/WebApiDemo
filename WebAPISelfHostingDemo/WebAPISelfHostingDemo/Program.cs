using System;
using System.Web.Http.SelfHost;

namespace WebAPISelfHostingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1 Create HostConfiguration
            var config = new HttpSelfHostConfiguration("http://localhost:8999");

            var server = new HttpSelfHostServer(config, new MyHttpMessageHandler());

           var task=  server.OpenAsync();
           task.Wait();
           Console.WriteLine("Server is Up and Running");
           Console.ReadLine();

        }
    }
}
