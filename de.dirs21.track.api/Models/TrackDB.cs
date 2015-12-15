using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace de.dirs21.track.api.Models
{
    public class TrackDB : DbContext
    {

        #region Properties
        public DbSet<TrackModel> TrackModel { get; set; }
        #endregion
    }
}