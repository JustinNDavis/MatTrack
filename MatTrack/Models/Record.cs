using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MatTrack.Models;

namespace MatTrack.Models
{
    public class Record
    {
        [Key]
        public int RecordId { get; set; }
        public int Wins { get; set; }
        public int Loss { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Users User { get; set; }
        [ForeignKey("AttendanceId")]
        public Attendance Attendance { get; set; }
    }
}
