using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Teacher
    {
        public int teacherid { get; set; }
        public string teachername { get; set; }

        public Teacher(int teacherid, string teachername)
        {
            this.teacherid = teacherid;
            this.teachername = teachername;
        }
    }
}
