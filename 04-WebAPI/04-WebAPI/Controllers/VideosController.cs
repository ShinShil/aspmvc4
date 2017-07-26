using _04_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
        public Video Get(int id)
        {
            var video = db.Videos.Find(id);
            if(video == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return video;
        }

        // POST: api/Videos
        public HttpResponseMessage Post(Video video)
        {
            if(ModelState.IsValid)
            {
                db.Videos.Add(video);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, video);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = video.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/Videos/5
        public HttpResponseMessage Put(int id, Video video)
        {
            if(ModelState.IsValid && id == video.Id)
            {
                db.Entry(video).State = System.Data.Entity.EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch(DbUpdateConcurrencyException e)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, video);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Videos/5
        public void Delete(int id)
        {
        }
    }
}
