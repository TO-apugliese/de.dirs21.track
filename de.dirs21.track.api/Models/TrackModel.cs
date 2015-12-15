using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace de.dirs21.track.api.Models
{
    public class TrackModel
    {
        [Key]
        public int ID { get; set; }
        public string AppName { get; set; }
        public string Version { get; set; }
        public string Domain { get; set; }
    }
}