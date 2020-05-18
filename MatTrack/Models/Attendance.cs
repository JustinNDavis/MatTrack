using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatTrack.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public DateTime StartDate { get; set; }
        public int Count { get; set; }
    }
}
