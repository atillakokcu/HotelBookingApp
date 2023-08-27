using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookignApp.Entity
{
    public class RoomProperties : BaseEntity
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int PropertiesId { get; set; }
        public Properties Properties { get; set; }
    }
}
