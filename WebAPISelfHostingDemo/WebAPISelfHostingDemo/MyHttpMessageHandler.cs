using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAPISelfHostingDemo
{
    class MyHttpMessageHandler : HttpMessageHandler
    {
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            Console.WriteLine("Recive an http message");
            var task = new Task<HttpResponseMessage>(() =>
            {
                var msg = new HttpResponseMessage();
                msg.Content = new StringContent("Hello Self Content");
                Console.WriteLine("http responce sent");
                return msg;
            });
            task.Start();
            return task;
        }
    }
}
