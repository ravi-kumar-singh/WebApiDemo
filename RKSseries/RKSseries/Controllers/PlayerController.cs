using RKSseries.DataAccess.Service;
using RKSseries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RKSseries.Controllers
{
    public class PlayerController : ApiController
    {
        private IRKService _service;
        private IModelFactory _modelFactory;
        public PlayerController( )
        {
            _service = new RKService();
            _modelFactory = new ModelFactory();
        }
        public IHttpActionResult Get()
        {
          var players=  _service.Players.Get();
          var models = players.Select(_modelFactory.Create);
          return Ok(models);
        }
    }
}
