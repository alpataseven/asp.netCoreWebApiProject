﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.EntityLayer.Concrete
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } // String olmasının sebebi girilecek oda numarasının B302, A405 vb. olacak olmasıdır.
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }

    }
}
