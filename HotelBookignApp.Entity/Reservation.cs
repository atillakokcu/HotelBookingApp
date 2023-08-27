using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookignApp.Entity
{
    public class Reservation : BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string MessageText { get; set; }
        public int AmountOfPerson { get; set; }
        public int AmountofChild { get; set; }

    }
}
