using System.Net.Http;
using System.Web.Mvc;

namespace HttpClientDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Tweets model = null;
            //Step 1: Create an instance of HTTPclient
            var client = new HttpClient();
            //Ste 2 : What URI we have to call , and then put inside appropriate methed like GetAsync or PostAsync
            // this call "client.GetAsync("http://search.twitter.com/search.json?q=pluralsight")" will return a task 
            var task = client.GetAsync("http://search.twitter.com/search.json?q=pluralsight")
                .ContinueWith((taskwithresponce) => {
                    //HttpResponseMessage response = null;
                    var response = taskwithresponce.Result;
                    //response.EnsureSuccessStatusCode();
                    var readtask = response.Content.ReadAsAsync<Tweets>();
                    readtask.Wait();
                    model = readtask.Result;
                });
    
            task.Wait();
          

            return View(model.results);
        }
    }
}
