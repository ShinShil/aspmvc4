using _04_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _04_WebAPI.Controllers
{
     public class VideosController : ApiController
    {
        private VideoDb db;

        public VideosController()
        {
            db = new VideoDb();
            db.Configuration.ProxyCreationEnabled = false; //turn of lazy loading, because in webapi typically we immediatly serialize and return the result
        }

        // GET: api/Videos
        public IEnumerable<Video> Get()
        {
            return db.Videos;
        }

        // GET: api/Videos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Videos
        public void Post([FromBody]int id)
        {
            
        }

        // PUT: api/Videos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Videos/5
        public void Delete(int id)
        {
        }
    }
}
