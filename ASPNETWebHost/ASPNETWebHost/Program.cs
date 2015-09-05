using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace ASPNETWebHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8999");
            config.Routes.MapHttpRoute("default", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            var server = new HttpSelfHostServer(config);

            var task = server.OpenAsync();
            task.Wait();
            Console.WriteLine("Server is Up and Running");
            Console.ReadLine();

        }
    }
}
