using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Course
    {
        public int courseid { get; set; }
        public string coursename { get; set; }

        public Course(int courseid, string coursename)
        {
            this.courseid = courseid;
            this.coursename = coursename;
        }
    }
}
