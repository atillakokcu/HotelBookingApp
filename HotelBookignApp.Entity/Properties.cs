using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookignApp.Entity
{
    public class Properties : BaseEntity
    {
        public string PropertiesDescription { get; set; }
        public List<RoomProperties> RoomProperties { get; set; }
    }
}
