using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MatTrack.Models;

namespace MatTrack.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BeltLevel Rank { get; set; }
        public int WeightInLbs { get; set; }
        public int HeightInInch { get; set; }
        public char CurrentlyInjured { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<Record> Records { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
    public enum BeltLevel
    {
        White,
        Blue,
        Purple,
        Brown,
        Black
    }
}