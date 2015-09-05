using System.Web.Http;

namespace ASPNETWebHost
{
   public class MyController: ApiController
    {
       public string Get()
       {
           return "Hello from Controller";
       }
    }
}
