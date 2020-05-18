using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatTrack.Models;

namespace MatTrack.Data
{
    public class MatTrackContext : DbContext
    {
        public MatTrackContext(DbContextOptions<MatTrackContext> options)
            : base(options)
        {
        }
        public DbSet<Users> User { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Record> Record { get; set; }
        public DbSet<UpcomingEvents> UpcomingEvents { get; set; }
    }
}
