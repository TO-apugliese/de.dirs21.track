using de.dirs21.track.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace de.dirs21.track.api.Controllers
{
    public class TrackController : ApiController
    {
        // GET: api/Track
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Track/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Track/Widgets
        [AllowAnonymous]
        public void Post([FromBody]TrackModel data)
        {
            var Tracker = new TrackDB();

            Tracker.TrackModel.Add(data);
            Tracker.SaveChanges();
        }

        // PUT: api/Track/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Track/5
        public void Delete(int id)
        {
        }
    }
}
