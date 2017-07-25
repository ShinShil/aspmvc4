using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _04_WebAPI.Controllers
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class VideoController : ApiController
    {
        // GET: api/Video
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Video/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Video
        public Video Post(Video value)
        {
            return value;
        }

        // PUT: api/Video/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Video/5
        public void Delete(int id)
        {
        }
    }
}
