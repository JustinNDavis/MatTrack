using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatTrack.Models
{
    public class UpcomingEvents
    {
        [Key]
        public int UpcomingEventsID { get; set; }
        public string Title { get; set; }
        public string EventSummary { get; set; }
        public float EventPrice { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }

    }
}
