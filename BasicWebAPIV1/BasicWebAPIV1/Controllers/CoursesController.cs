using BasicWebAPIV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicWebAPIV1.Controllers
{
    public class CoursesController : ApiController
    {
        static List<cource> cources = InitCources();

        private static List<cource> InitCources()
        {
            var result = new List<cource>();
            result.Add(new cource { id = 01, title = "ASP.NET" });
            result.Add(new cource { id = 02, title = "MVC 5" });
            return result;
        }

        //Method 01
        public IEnumerable<cource> Get()
        {
            return cources;
        }

        //Method 01
        //[HttpGet]
        // public cource AllCourses(int Id) => with no httpget
        //public cource Get(int Id)
        //{
        //    var result = cources.Where(c => c.id == Id).FirstOrDefault();
        //    return result;
        //}

        //Method 02
        //public HttpResponseMessage Get(int Id)
        //{
        //    HttpResponseMessage msg = null;
        //    var result = cources.Where(c => c.id == Id).FirstOrDefault();

        //    if (result == null)
        //    {
        //        msg = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Cource Not Fount!");

        //    }
        //    else
        //    {
        //        msg = Request.CreateResponse<cource>(HttpStatusCode.OK, result);

        //    }
        //    return msg;
        //}

        //Method 03
        public IHttpActionResult Get(int Id)
        {
            var result = cources.Where(c => c.id == Id).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }


        //Method 01
        //public void Post([FromBody]cource c)
        //{
        //    c.id = cources.Count;
        //    cources.Add(c);
        //}

        //Method 02
        public HttpResponseMessage Post([FromBody]cource c)
        {
            c.id = cources.Count;
            cources.Add(c);
            //should retrn 201 with a location header
            var msg = Request.CreateResponse(HttpStatusCode.Created);
            msg.Headers.Location = new Uri(Request.RequestUri + c.id.ToString());
            return msg;

        }

        //Method 01
        public void Put(int id, [FromBody]cource cour)
        {
            var result = cources.Where(c => id == id).FirstOrDefault();
            //(from c in cources
            // where c.id == id
            //  select c).FirstOrDefault();
            result.title = cour.title;
        }

        //Method 02


        //Method 01
        public void delete(int id)
        {
            var result = cources.Where(c => c.id == id).FirstOrDefault();
            //(from c in cources
            //  where c.id == id
            //  select c).FirstOrDefault();

            cources.Remove(result);

        }

        //Method 02


    }
}
