using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Room
    {
        public int roomid { get; set; }
        public string roomname { get; set; }

        public Room(int roomid, string roomname)
        {
            this.roomid = roomid;
            this.roomname = roomname;
        }

    }
}
