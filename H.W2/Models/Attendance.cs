using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Attendance
    {
        public string Teacher { get; set; }
        public string Course { get; set; }
        public string Room { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string LeaveTime { get; set; }
        public string Comment { get; set; }

        public Attendance(string teacher, string course, string room, string date, string startTime, string leaveTime, string comment)
        {
            Teacher = teacher;
            Course = course;
            Room = room;
            Date = date;
            StartTime = startTime;
            LeaveTime = leaveTime;
            Comment = comment;
        }
    }
}
