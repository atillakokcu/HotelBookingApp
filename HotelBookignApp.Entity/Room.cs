using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookignApp.Entity
{
    public class Room : BaseEntity
    {
        public string RoomName { get; set; }
        public decimal RoomPrice { get; set; }
        public int GuestCapacity { get; set; }
        public int RoomSize { get; set; }
        public string RoomDescription { get; set; }
        public string RoomImagesMain { get; set; }
        public string? RoomImages1 { get; set; }
        public string? RoomImages2 { get; set; }
        public List<RoomProperties> RoomProperties { get; set; }
        public List<Reservation> Reservation { get; set; }

    }
}
